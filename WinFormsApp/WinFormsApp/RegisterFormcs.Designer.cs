using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormsApp
{
    partial class RegisterFormcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterFormcs));
            MainPannelR = new Panel();
            PassportField = new TextBox();
            pictureBox3 = new PictureBox();
            NameField = new TextBox();
            pictureBox4 = new PictureBox();
            ButtonRegister = new Button();
            PasswordField = new TextBox();
            pictureBox2 = new PictureBox();
            LoginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            CloseButtonR = new Label();
            label1 = new Label();
            ButtonLogin = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            MainPannelR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPannelR
            // 
            MainPannelR.BackColor = Color.FromArgb(20, 101, 135);
            MainPannelR.Controls.Add(flowLayoutPanel1);
            MainPannelR.Controls.Add(ButtonLogin);
            MainPannelR.Controls.Add(PassportField);
            MainPannelR.Controls.Add(pictureBox3);
            MainPannelR.Controls.Add(NameField);
            MainPannelR.Controls.Add(pictureBox4);
            MainPannelR.Controls.Add(ButtonRegister);
            MainPannelR.Controls.Add(PasswordField);
            MainPannelR.Controls.Add(pictureBox2);
            MainPannelR.Controls.Add(LoginField);
            MainPannelR.Controls.Add(pictureBox1);
            MainPannelR.Controls.Add(panel2);
            MainPannelR.Dock = DockStyle.Fill;
            MainPannelR.Location = new Point(0, 0);
            MainPannelR.Name = "MainPannelR";
            MainPannelR.Size = new Size(1150, 700);
            MainPannelR.TabIndex = 1;
            MainPannelR.Paint += MainPannelR_Paint;
            MainPannelR.MouseDown += MainPannelR_MouseDown;
            MainPannelR.MouseMove += MainPannelR_MouseMove;
            // 
            // PassportField
            // 
            PassportField.Cursor = Cursors.IBeam;
            PassportField.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PassportField.Location = new Point(359, 287);
            PassportField.Multiline = true;
            PassportField.Name = "PassportField";
            PassportField.PasswordChar = '*';
            PassportField.Size = new Size(489, 48);
            PassportField.TabIndex = 9;
            PassportField.UseSystemPasswordChar = true;
            PassportField.Enter += PassportField_Enter;
            PassportField.Leave += PassportField_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(305, 287);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // NameField
            // 
            NameField.Cursor = Cursors.IBeam;
            NameField.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NameField.Location = new Point(359, 187);
            NameField.Multiline = true;
            NameField.Name = "NameField";
            NameField.Size = new Size(489, 48);
            NameField.TabIndex = 7;
            NameField.Enter += NameField_Enter;
            NameField.Leave += NameField_Leave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(305, 187);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // ButtonRegister
            // 
            ButtonRegister.BackColor = Color.FromArgb(128, 255, 128);
            ButtonRegister.Cursor = Cursors.Hand;
            ButtonRegister.FlatAppearance.BorderSize = 0;
            ButtonRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            ButtonRegister.FlatAppearance.MouseOverBackColor = Color.Lime;
            ButtonRegister.FlatStyle = FlatStyle.Flat;
            ButtonRegister.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonRegister.Location = new Point(439, 587);
            ButtonRegister.Name = "ButtonRegister";
            ButtonRegister.Size = new Size(313, 41);
            ButtonRegister.TabIndex = 5;
            ButtonRegister.Text = "Зарегистрироваться";
            ButtonRegister.UseVisualStyleBackColor = false;
            ButtonRegister.Click += ButtonRegister_Click;
            // 
            // PasswordField
            // 
            PasswordField.Cursor = Cursors.IBeam;
            PasswordField.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordField.Location = new Point(359, 498);
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.Size = new Size(489, 39);
            PasswordField.TabIndex = 4;
            PasswordField.UseSystemPasswordChar = true;
            PasswordField.Enter += PasswordField_Enter;
            PasswordField.Leave += PasswordField_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.LOGIN_lock_icon;
            pictureBox2.Location = new Point(305, 490);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // LoginField
            // 
            LoginField.Cursor = Cursors.IBeam;
            LoginField.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LoginField.Location = new Point(359, 389);
            LoginField.Multiline = true;
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(489, 48);
            LoginField.TabIndex = 2;
            LoginField.Enter += LoginField_Enter;
            LoginField.Leave += LoginField_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGIN_user_icon;
            pictureBox1.Location = new Point(305, 389);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(CloseButtonR);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 125);
            panel2.TabIndex = 0;
            // 
            // CloseButtonR
            // 
            CloseButtonR.AutoSize = true;
            CloseButtonR.Cursor = Cursors.Hand;
            CloseButtonR.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CloseButtonR.ForeColor = Color.Firebrick;
            CloseButtonR.Location = new Point(1105, 9);
            CloseButtonR.Name = "CloseButtonR";
            CloseButtonR.Size = new Size(33, 35);
            CloseButtonR.TabIndex = 1;
            CloseButtonR.Text = "X";
            CloseButtonR.Click += CloseButtonR_Click;
            CloseButtonR.MouseEnter += CloseButtonR_MouseEnter_1;
            CloseButtonR.MouseLeave += CloseButtonR_MouseLeave_1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1150, 125);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.TopCenter;
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
            ButtonLogin.Location = new Point(478, 647);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(231, 41);
            ButtonLogin.TabIndex = 6;
            ButtonLogin.Text = "Авторизоваться";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1058, 706);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(110, 12);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // RegisterFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 700);
            Controls.Add(MainPannelR);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterFormcs";
            Text = "RegisterFormcs";
            MainPannelR.ResumeLayout(false);
            MainPannelR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPannelR;
        private Button ButtonRegister;
        private TextBox PasswordField;
        private PictureBox pictureBox2;
        private TextBox LoginField;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label CloseButtonR;
        private Label label1;
        private TextBox PassportField;
        private PictureBox pictureBox3;
        private TextBox NameField;
        private PictureBox pictureBox4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ButtonLogin;
    }
}