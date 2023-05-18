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

namespace WinFormsApp
{
    public partial class CardView : Form
    {
        private string card_name;
        private int card_id;
        private string userLogin;
        public CardView(string Card_name, int id, string login)
        {
            InitializeComponent();
            labelCardName.Text = Card_name;
            card_name = Card_name;
            card_id = id;
            userLogin = login;
            dataGridViewProjShow();
            dataGridViewTaskShow();
            dataGridViewTaskToDoShow();
            dataGridViewTasksDoneShow();
        }
        private void dataGridViewTaskToDO_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridViewProj_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void MainPannelM_Paint(object sender, PaintEventArgs e) { }
        private void dataGridViewTasksDone_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainPannelM_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(82, 16, 6);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Firebrick;
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

        private void dataGridViewProjShow()
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT `users`.`name` AS `Глава проекта`, `cards`.`card_name` AS `Название проекта`, `cards`.`card_description` AS `Описание проекта` FROM `users`, `cards` WHERE cards.team_leader_id = users.id AND cards.id = @cID", db.getConnection());
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewProj.DataSource = table;
            db.CloseConnection();
        }



        private void dataGridViewTaskShow()
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT tasks.name AS `Задача`, tasks.description AS `Описание`, users.name AS `Работает над задачей` FROM `users`, `tasks`, `task_workers`, `cards` WHERE `users`.`id` = `task_workers`.`task_worker_id` AND `tasks`.`card_id` = @cID AND `tasks`.`card_id`= `cards`.`id` AND `task_workers`.`task_id` = `tasks`.`id` AND `tasks`.`task_in_developing` = 0;", db.getConnection());
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewTasks.DataSource = table;
            db.CloseConnection();
        }

        private void dataGridViewTaskToDoShow()
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT tasks.name AS `Задача`, tasks.description AS `Описание`, users.name AS `Работает над задачей` FROM `users`, `tasks`, `task_workers`, `cards` WHERE `users`.`id` = `task_workers`.`task_worker_id` AND `tasks`.`card_id` = @cID AND `tasks`.`card_id`= `cards`.`id` AND `task_workers`.`task_id` = `tasks`.`id` AND `tasks`.`task_in_developing` = 1 AND `tasks`.`task_completed` = 0;", db.getConnection());
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewTaskToDO.DataSource = table;
            db.CloseConnection();
        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string? task_name = dataGridViewTasks.CurrentCell.Value.ToString();
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT `id` FROM `tasks` WHERE `name` = @tN AND `card_id` = @cID", db.getConnection());
            command.Parameters.Add("@tN", MySqlDbType.VarChar).Value = task_name;
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                textBoxTaskName.Text = task_name;
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxTaskName.Text != "")
            {
                DataBase db = new DataBase();
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET `tasks`.`task_in_developing` = 1 WHERE `tasks`.`name` = @tN AND `tasks`.`card_id` = @cID", db.getConnection());
                command.Parameters.Add("@tN", MySqlDbType.VarChar).Value = textBoxTaskName.Text;
                command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.CloseConnection();
                textBoxTaskName.Text = "";
                this.Close();
                CardView form = new CardView(card_name, card_id, userLogin);
                form.Show();
            }
            else
            {
                return;
            }
        }

        private void buttonTaskCompleted_Click(object sender, EventArgs e)
        {
            if (textBoxTaskToDoName.Text != "")
            {
                DataBase db = new DataBase();
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET `tasks`.`task_completed` = 1 WHERE `tasks`.`name` = @tN AND `tasks`.`card_id` = @cID", db.getConnection());
                command.Parameters.Add("@tN", MySqlDbType.VarChar).Value = textBoxTaskToDoName.Text;
                command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.CloseConnection();
                textBoxTaskName.Text = "";
                this.Close();
                CardView form = new CardView(card_name, card_id, userLogin);
                form.Show();
            }
            else
            {
                return;
            }
        }

        private void dataGridViewTaskToDO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string? task_name = dataGridViewTaskToDO.CurrentCell.Value.ToString();
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT `id` FROM `tasks` WHERE `name` = @tN AND `card_id` = @cID", db.getConnection());
            command.Parameters.Add("@tN", MySqlDbType.VarChar).Value = task_name;
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                textBoxTaskToDoName.Text = task_name;
            }
            else
            {
                return;
            }
        }

        private void dataGridViewTasksDoneShow()
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT tasks.name AS `Задача`, tasks.description AS `Описание`, users.name AS `Работает над задачей` FROM `users`, `tasks`, `task_workers`, `cards` WHERE `users`.`id` = `task_workers`.`task_worker_id` AND `tasks`.`card_id` = @cID AND `tasks`.`card_id`= `cards`.`id` AND `task_workers`.`task_id` = `tasks`.`id` AND `tasks`.`task_completed` = 1;", db.getConnection());
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewTasksDone.DataSource = table;
            db.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.ReturnToMainForm();
        }

        private void buttonCardEdit_Click(object sender, EventArgs e)
        {
            this.Close();
            CardEdit form = new CardEdit(card_id, card_name, userLogin);
            form.Show();
        }
    }
}