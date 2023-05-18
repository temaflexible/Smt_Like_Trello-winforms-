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
    public partial class RegisterFormcs : Form
    {
        public RegisterFormcs()
        {
            InitializeComponent();

            PasswordField.UseSystemPasswordChar = false;

            NameField.Text = "Введите ФИО";

            PassportField.Text = "Введите паспортные данные(слитно)";

            LoginField.Text = "Придумайте логин";

            PasswordField.Text = "Придумайте пароль";
        }

        private void CloseButtonR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPannelR_Paint(object sender, PaintEventArgs e) { }

        Point LastPoint;

        private void MainPannelR_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MainPannelR_MouseDown(object sender, MouseEventArgs e) => LastPoint = new Point(e.X, e.Y);

        private void CloseButtonR_MouseEnter_1(object sender, EventArgs e)
        {
            CloseButtonR.ForeColor = Color.FromArgb(82, 16, 6);
        }

        private void CloseButtonR_MouseLeave_1(object sender, EventArgs e)
        {
            CloseButtonR.ForeColor = Color.Firebrick;
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите ФИО")
            {
                NameField.Text = "";
            }
        }

        private void PassportField_Enter(object sender, EventArgs e)
        {
            if (PassportField.Text == "Введите паспортные данные(слитно)")
            {
                PassportField.Text = "";
            }
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Придумайте логин")
            {
                LoginField.Text = "";
            }
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (PasswordField.Text == "Придумайте пароль")
            {
                PasswordField.Text = "";
            }
            PasswordField.UseSystemPasswordChar = true;
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Придумайте логин";
            }
        }

        private void PassportField_Leave(object sender, EventArgs e)
        {
            if (PassportField.Text == "")
            {
                PassportField.Text = "Введите паспортные данные(слитно)";
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Введите ФИО";
            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (PasswordField.Text == "")
            {
                PasswordField.Text = "Придумайте пароль";
            }
            PasswordField.UseSystemPasswordChar = false;
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (CheckRegisterLogin() || CheckRegisterPassport())
            {
                return;
            }


            if (LoginField.Text == "Придумайте логин" || PassportField.Text == "Введите паспортные данные(слитно)" || PasswordField.Text == "Придумайте пароль" || NameField.Text == "Введите ФИО")
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }

            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `login`, `password`, `passport`) VALUES (@name, @uL, @uP, @Passport)", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameField.Text;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PasswordField.Text;
            command.Parameters.Add("@Passport", MySqlDbType.VarChar).Value = PassportField.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Register successed");
            }
            else
            {
                MessageBox.Show("Register failed");
            }

            db.CloseConnection();
        }

        private Boolean CheckRegisterLogin()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("You login has already been registered");
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean CheckRegisterPassport()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `passport` = @uP", db.getConnection());
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassportField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("You passport has already been registered");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }
    }
}