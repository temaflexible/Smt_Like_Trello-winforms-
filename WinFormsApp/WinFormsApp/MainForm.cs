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
    public partial class MainForm : Form
    {
        static string? main_name;
        static string? main_passport;
        static string? main_login;

        public MainForm(string passport, string name, string login)
        {
            InitializeComponent();
            labelName.Text = name;
            labelLogin.Text = login;
            labelPassport.Text = passport;
            main_name = name;
            main_login = login;
            main_passport = passport;
        }

        public static void ReturnToMainForm()
        {
            MainForm form = new MainForm(main_passport, main_name, main_login);
            form.Show();
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

        private void MainPannelM_MouseDown(object sender, MouseEventArgs e) => LastPoint = new Point(e.X, e.Y);

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            string userLogin = labelLogin.Text;
            CardConstructorcs cardConstructorcs = new CardConstructorcs(userLogin);
            cardConstructorcs.Show();
        }

        private void buttonMyCards_Click(object sender, EventArgs e)
        {
            this.Close();
            MyCards form = new MyCards(main_login);
            form.Show();
        }
    }
}