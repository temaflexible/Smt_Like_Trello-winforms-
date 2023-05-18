using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp
{
    public partial class AddWorkers : Form
    {

        private int card_id;
        private string user_login;
        public AddWorkers(int Card_id, string login)
        {
            InitializeComponent();
            card_id = Card_id;
            label1.Text = card_id.ToString();
            user_login = login;
        }

        private int getWorkerID(string worker)
        {
            DataBase db = new DataBase();
            MySqlCommand Id = new MySqlCommand("SELECT `id` FROM `users` WHERE `login` = @uL", db.getConnection());
            Id.Parameters.Add("@uL", MySqlDbType.VarChar).Value = worker;

            db.OpenConnection();
            object ID = Id.ExecuteScalar();
            db.CloseConnection();
            int id = Convert.ToInt32(ID);
            label2.Text = id.ToString();
            return id;
        }

        private void AddWorker(int card_id)
        {
            if (IsUserExists(workerLoginBox.Text))
            {
                string worker_login = workerLoginBox.Text;
                WorkersListBox.Text = WorkersListBox.Text + workerLoginBox.Text + "\t";
                workerLoginBox.Text = "";
                DataBase db = new DataBase();
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO `card_workers` (`worker_id`, `card_id`) VALUES (@w, @cID)", db.getConnection());
                command.Parameters.Add("@w", MySqlDbType.Int32).Value = getWorkerID(worker_login);
                command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.CloseConnection();
            }

        }

        private bool IsUserExists(string login)
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT `id` FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = workerLoginBox.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.CloseConnection();

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                workerLoginBox.Text = "";
                MessageBox.Show("Такого пользователя не существует");
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddWorker(card_id);

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

        private void labelNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTasks form = new AddTasks(card_id, user_login);
            form.Show();
        }
    }
}