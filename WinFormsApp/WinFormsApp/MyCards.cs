using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MyCards : Form
    {
        private string userLogin;
        private int card_id;
        public MyCards(string login)
        {
            InitializeComponent();
            userLogin = login;
            ShowdataGridViewLeader();
            ShowdataGridViewWorker();
        }

        private void ShowdataGridViewLeader()
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT cards.`card_name` AS `Название проекта` FROM `cards`, `users` WHERE users.`id` = @uID AND `users`.`id` = cards.team_leader_id", db.getConnection());
            command.Parameters.Add("@uID", MySqlDbType.Int32).Value = DataBase.getUserID(userLogin);
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewLeader.DataSource = table;
            db.CloseConnection();
        }

        private void ShowdataGridViewWorker()
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT cards.`card_name` AS `Название проекта` FROM `cards`, `users`, `card_workers` WHERE users.`id` = @uID AND card_workers.`worker_id` = users.id  AND card_workers.card_id = cards.id", db.getConnection());
            command.Parameters.Add("@uID", MySqlDbType.Int32).Value = DataBase.getUserID(userLogin);
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewWorker.DataSource = table;
            db.CloseConnection();

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

        private void dataGridViewLeader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelSelectProj.Text = dataGridViewLeader.CurrentCell.Value.ToString();
            labelSelectProj.BackColor = Color.Turquoise;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT `id` FROM `cards` WHERE `team_leader_id` = @tID AND `card_name` = @cN", db.getConnection());
            command.Parameters.Add("@tID", MySqlDbType.Int32).Value = DataBase.getUserID(userLogin);
            command.Parameters.Add("@cN", MySqlDbType.VarChar).Value = labelSelectProj.Text;
            db.OpenConnection();
            object cID = command.ExecuteScalar();
            card_id = Convert.ToInt32(cID);
            db.CloseConnection();
        }

        private void dataGridViewWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelSelectProj.Text = dataGridViewWorker.CurrentCell.Value.ToString();
            labelSelectProj.BackColor = Color.Turquoise;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT cards.id FROM `cards` , `card_workers`, `users` WHERE cards.card_name = @cN AND `users`.`id` = @uID AND `card_workers`.`worker_id` = `users`.`id` AND `card_workers`.`card_id` = `cards`.`id`", db.getConnection());
            command.Parameters.Add("@cN", MySqlDbType.VarChar).Value = labelSelectProj.Text;
            command.Parameters.Add("@uID", MySqlDbType.Int32).Value = DataBase.getUserID(userLogin);
            db.OpenConnection();
            object cID = command.ExecuteScalar();
            card_id = Convert.ToInt32(cID);
            db.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelSelectProj.Text == "")
            {
                MessageBox.Show("Вы не выбрали проект");
            }
            else
            {
                CardView form = new CardView(labelSelectProj.Text, card_id, userLogin);
                form.Show();
                this.Close();
            }
        }

        private void buttonReturnToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.ReturnToMainForm();
        }
    }
}