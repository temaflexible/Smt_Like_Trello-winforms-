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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(this.PasswordField.Size.Width, 48);
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void LogInForm_Load(object sender, EventArgs e) { }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginField_TextChanged(object sender, EventArgs e) { }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(82, 16, 6);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Firebrick;
        }

        Point LastPoint;

        private void MainPannel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MainPannel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (LoginField.Text != "" && LoginField.Text != "" && CheckRegisterLogin())
            {
                string UserLogin = LoginField.Text;
                string UserPassword = PasswordField.Text;

                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = UserLogin;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = UserPassword;

                MySqlCommand Passport = new MySqlCommand("SELECT `passport` FROM `users` WHERE `login` = @uL", db.getConnection());
                Passport.Parameters.Add("@uL", MySqlDbType.VarChar).Value = UserLogin;

                MySqlCommand Name = new MySqlCommand("SELECT `name` FROM `users` WHERE `login` = @uL", db.getConnection());
                Name.Parameters.Add("@uL", MySqlDbType.VarChar).Value = UserLogin;

                db.OpenConnection();
                string? passport = Passport.ExecuteScalar().ToString();
                string? name = Name.ExecuteScalar().ToString();
                db.CloseConnection();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(passport, name, UserLogin);
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }

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
                return true;
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль");
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e){}

        private void PasswordField_TextChanged(object sender, EventArgs e){}

        private void pictureBox2_Click(object sender, EventArgs e){}

        private void MainPannel_Paint(object sender, PaintEventArgs e){}

        private void GoToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterFormcs registerForm = new RegisterFormcs();
            registerForm.Show();
        }

    }
}