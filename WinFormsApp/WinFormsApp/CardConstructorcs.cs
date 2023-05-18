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

namespace WinFormsApp
{
    public partial class CardConstructorcs : Form
    {
        private string userLogin;
        public CardConstructorcs(string login)
        {
            InitializeComponent();
            userLogin = login;
        }

        private int getTeamLeaderID(string userLogin)
        {
            DataBase db = new DataBase();
            MySqlCommand Id = new MySqlCommand("SELECT `id` FROM `users` WHERE `login` = @uL", db.getConnection());
            Id.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;

            db.OpenConnection();
            object ID = Id.ExecuteScalar();
            db.CloseConnection();
            int id = Convert.ToInt32(ID);
            return id;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelNext_Click(object sender, EventArgs e)
        {
            string name = SelectcardNameBox.Text;
            string description = DescriptionBox.Text;
            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO `cards` (`team_leader_id`, `card_name`, `card_description`, `card_completed`) VALUES (@tL, @cN, @cD, 0)", db.getConnection());
            command.Parameters.Add("@tL", MySqlDbType.VarChar).Value = getTeamLeaderID(userLogin);
            command.Parameters.Add("@cN", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@cD", MySqlDbType.VarChar).Value = description;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("The card was created");
                this.Hide();
                AddWorkers form = new AddWorkers(GetCardID(), userLogin);
                form.Show();
            }
            else
            {
                MessageBox.Show("The card was not created");
            }

            db.CloseConnection();
        }

        private int GetCardID()
        {
            string name = SelectcardNameBox.Text;
            string description = DescriptionBox.Text;

            DataBase db = new DataBase();
            MySqlCommand Id = new MySqlCommand("SELECT `id` FROM `cards` WHERE `team_leader_id` = @tL AND `card_name` = @cN AND `card_description` = @cD", db.getConnection());
            Id.Parameters.Add("@tL", MySqlDbType.Int32).Value = getTeamLeaderID(userLogin);
            Id.Parameters.Add("@cN", MySqlDbType.VarChar).Value = name;
            Id.Parameters.Add("@cD", MySqlDbType.VarChar).Value = description;

            db.OpenConnection();
            object ID = Id.ExecuteScalar();
            db.CloseConnection();
            int id = Convert.ToInt32(ID);

            return id;
        }


        private void SelectNameLabel_Click(object sender, EventArgs e) { }

        private void SelectcardNameBox_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
    }
}