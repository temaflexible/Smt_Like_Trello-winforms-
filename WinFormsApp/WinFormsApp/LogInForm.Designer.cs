namespace WinFormsApp
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainPannel = new Panel();
            ButtonLogin = new Button();
            PasswordField = new TextBox();
            pictureBox2 = new PictureBox();
            LoginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            CloseButton = new Label();
            label1 = new Label();
            GoToRegister = new Label();
            MainPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPannel
            // 
            MainPannel.BackColor = Color.FromArgb(20, 101, 135);
            MainPannel.Controls.Add(GoToRegister);
            MainPannel.Controls.Add(ButtonLogin);
            MainPannel.Controls.Add(PasswordField);
            MainPannel.Controls.Add(pictureBox2);
            MainPannel.Controls.Add(LoginField);
            MainPannel.Controls.Add(pictureBox1);
            MainPannel.Controls.Add(panel2);
            MainPannel.Dock = DockStyle.Fill;
            MainPannel.Location = new Point(0, 0);
            MainPannel.Name = "MainPannel";
            MainPannel.Size = new Size(1150, 700);
            MainPannel.TabIndex = 0;
            MainPannel.Paint += MainPannel_Paint;
            MainPannel.MouseDown += MainPannel_MouseDown;
            MainPannel.MouseMove += MainPannel_MouseMove;
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.FromArgb(128, 255, 128);
            ButtonLogin.Cursor = Cursors.Hand;
            ButtonLogin.FlatAppearance.BorderSize = 0;
            ButtonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            ButtonLogin.FlatAppearance.MouseOverBackColor = Color.Lime;
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonLogin.Location = new Point(535, 479);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(113, 41);
            ButtonLogin.TabIndex = 5;
            ButtonLogin.Text = "Войти";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // PasswordField
            // 
            PasswordField.Cursor = Cursors.IBeam;
            PasswordField.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordField.Location = new Point(476, 382);
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.Size = new Size(259, 39);
            PasswordField.TabIndex = 4;
            PasswordField.UseSystemPasswordChar = true;
            PasswordField.TextChanged += PasswordField_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LOGIN_lock_icon;
            pictureBox2.Location = new Point(422, 382);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginField
            // 
            LoginField.Cursor = Cursors.IBeam;
            LoginField.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LoginField.Location = new Point(476, 282);
            LoginField.Multiline = true;
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(259, 48);
            LoginField.TabIndex = 2;
            LoginField.TextChanged += LoginField_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGIN_user_icon;
            pictureBox1.Location = new Point(422, 282);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 125);
            panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.Firebrick;
            CloseButton.Location = new Point(1105, 9);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(33, 35);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1150, 125);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // GoToRegister
            // 
            GoToRegister.AutoSize = true;
            GoToRegister.BackColor = Color.PaleGreen;
            GoToRegister.Cursor = Cursors.Hand;
            GoToRegister.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            GoToRegister.Location = new Point(464, 587);
            GoToRegister.Name = "GoToRegister";
            GoToRegister.Size = new Size(271, 32);
            GoToRegister.TabIndex = 6;
            GoToRegister.Text = "Зарегистрироваться";
            GoToRegister.Click += GoToRegister_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 700);
            Controls.Add(MainPannel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInForm";
            Load += LogInForm_Load;
            MainPannel.ResumeLayout(false);
            MainPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPannel;
        private Panel panel2;
        private Label label1;
        private Label CloseButton;
        private PictureBox pictureBox1;
        private TextBox PasswordField;
        private PictureBox pictureBox2;
        private TextBox LoginField;
        private Button ButtonLogin;
        private Label GoToRegister;
    }
}