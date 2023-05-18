using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp
{
    public partial class AddTasks : Form
    {

        private int card_id;
        private string user_login;
        private bool add_worker = false;
        public AddTasks(int i, string login)
        {
            InitializeComponent();
            card_id = i;
            user_login = login;
            ShowDataGrid();
        }

        private void ShowDataGrid()
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT users.`login` AS `Логин` FROM `users`, `card_workers` WHERE card_workers.`card_id` = @cid AND users.id = card_workers.worker_id", db.getConnection());
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;
            db.CloseConnection();

        }

        Point LastPoint;

        private void MainPannelM_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MainPannelM_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(82, 16, 6);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Firebrick;
        }

        private int GetLastTaskId()
        {
            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("SELECT `id` FROM `tasks` WHERE `task_author` = @tA AND `card_id` = @cID AND `name` = @tN AND `description` = @tD", db.getConnection());
            command.Parameters.Add("@tA", MySqlDbType.Int32).Value = last_task_author;
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = last_card_id;
            command.Parameters.Add("@tN", MySqlDbType.VarChar).Value = last_task_name;
            command.Parameters.Add("@tD", MySqlDbType.VarChar).Value = last_task_desc;
            db.OpenConnection();
            object ID = command.ExecuteScalar();
            db.CloseConnection();
            int id = Convert.ToInt32(ID);
            return id;
        }

        private string? last_task_name;
        private string? last_task_desc;
        private int last_task_author;
        private int last_card_id;

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string task_name = SelectTaskNameBox.Text;
            string task_desc = DescriptionBox.Text;
            int task_author = getUserID(user_login);

            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO `tasks` (`id`, `task_author`, `card_id`, `name`, `description`, `task_completed`, `task_in_developing`) VALUES (NULL, @uID, @cID, @tN, @tD, 0, 0);", db.getConnection());
            command.Parameters.Add("@uID", MySqlDbType.Int32).Value = task_author;
            command.Parameters.Add("cID", MySqlDbType.Int32).Value = card_id;
            command.Parameters.Add("@tN", MySqlDbType.VarChar).Value = task_name;
            command.Parameters.Add("@tD", MySqlDbType.VarChar).Value = task_desc;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("The task was created");
                last_task_name = task_name;
                last_task_desc = task_desc;
                last_task_author = task_author;
                last_card_id = card_id;
                add_worker = true;
            }
            else
            {
                MessageBox.Show("The task was not created");
            }

            db.CloseConnection();


        }

        private int getUserID(string login)
        {
            DataBase db = new DataBase();
            MySqlCommand Id = new MySqlCommand("SELECT `id` FROM `users` WHERE `login` = @uL", db.getConnection());
            Id.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            db.OpenConnection();
            object ID = Id.ExecuteScalar();
            db.CloseConnection();
            int id = Convert.ToInt32(ID);
            label2.Text = id.ToString();
            return id;
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            if (IsAbleToAdd())
            {
                if (IsWorkerInCard())
                {
                    string worker_login = WorkerLoginBox.Text;
                    DataBase db = new DataBase();

                    MySqlCommand command = new MySqlCommand("INSERT INTO `task_workers` (`id`, `task_worker_id`, `task_id`) VALUES (NULL, @wID, @tID);", db.getConnection());
                    command.Parameters.Add("@wID", MySqlDbType.Int32).Value = getUserID(worker_login);
                    command.Parameters.Add("@tID", MySqlDbType.Int32).Value = GetLastTaskId();
                    db.OpenConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("The " + worker_login + " was added to " + last_task_name + " task");

                    }
                    else
                    {
                        MessageBox.Show("The worker was not added");
                    }

                    db.CloseConnection();
                }
            }
        }

        private bool IsAbleToAdd()
        {
            if (add_worker == false)
            {
                MessageBox.Show("Сначала добавьте задачу");
            }
            return add_worker;
        }

        private bool IsWorkerInCard()
        {
            bool IS = false;
            string worker_login = WorkerLoginBox.Text;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT `card_workers`.`worker_id` FROM `card_workers`, `cards` WHERE card_workers.worker_id = @wID AND card_workers.card_id = @cID AND card_workers.card_id = cards.id", db.getConnection());
            command.Parameters.Add("@wID", MySqlDbType.Int32).Value = getUserID(WorkerLoginBox.Text);
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                IS = true;
            }
            else
            {
                MessageBox.Show("Это пользователь не участвует в проекте");
            }
            return IS;
        }

        private void labelNext_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.ReturnToMainForm();

        }
    }
}