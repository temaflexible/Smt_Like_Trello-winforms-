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
    public partial class CardEdit : Form
    {
        private int card_id;
        private string card_name;
        private string user_login;
        public CardEdit(int Card_id, string Card_name, string User_login)
        {
            InitializeComponent();
            card_id = Card_id;
            CardNameShow();
            CardDescShow();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmEdit_Click(object sender, EventArgs e)
        {
            if (textBoxCardName.Text != "" && textBoxCardDesc.Text != "")
            {
                DataBase db = new DataBase();
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("UPDATE `cards` SET `card_name` = @cN ,`card_description`= @cD  WHERE `cards`.`id` = @cID", db.getConnection());
                command.Parameters.Add("@cN", MySqlDbType.VarChar).Value = textBoxCardName.Text;
                command.Parameters.Add("@cD", MySqlDbType.VarChar).Value = textBoxCardDesc.Text;
                command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.CloseConnection();
                CardEdit form = new CardEdit(card_id, card_name, user_login);
                this.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("Нельзя просто так взять и удалить данные");
            }
        }

        private void CardNameShow()
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT `card_name` FROM `cards` WHERE `id` = @cID", db.getConnection());
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
            object name = command.ExecuteScalar();
            textBoxCardName.Text = Convert.ToString(name);
            card_name = textBoxCardName.Text;
            db.CloseConnection();
        }

        private void CardDescShow()
        {
            DataBase db = new DataBase();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT `card_description` FROM `cards` WHERE `id` = @cID", db.getConnection());
            command.Parameters.Add("@cID", MySqlDbType.Int32).Value = card_id;
            object name = command.ExecuteScalar();
            textBoxCardDesc.Text = Convert.ToString(name);
            db.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardView form = new CardView(card_name, card_id, user_login);
            this.Close();
            form.Show();
        }
    }
}
