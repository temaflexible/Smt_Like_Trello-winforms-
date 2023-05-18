namespace WinFormsApp
{
    partial class MainForm
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
            MainPannelM = new Panel();
            buttonMyCards = new Button();
            CreateCard = new Button();
            labelLogin = new Label();
            labelPassport = new Label();
            labelName = new Label();
            label1 = new Label();
            panel2 = new Panel();
            CloseButton = new Label();
            LabelUserInfo = new Label();
            MainPannelM.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPannelM
            // 
            MainPannelM.BackColor = Color.FromArgb(20, 101, 135);
            MainPannelM.Controls.Add(buttonMyCards);
            MainPannelM.Controls.Add(CreateCard);
            MainPannelM.Controls.Add(labelLogin);
            MainPannelM.Controls.Add(labelPassport);
            MainPannelM.Controls.Add(labelName);
            MainPannelM.Controls.Add(label1);
            MainPannelM.Controls.Add(panel2);
            MainPannelM.Dock = DockStyle.Fill;
            MainPannelM.Location = new Point(0, 0);
            MainPannelM.Name = "MainPannelM";
            MainPannelM.Size = new Size(1600, 900);
            MainPannelM.TabIndex = 1;
            MainPannelM.MouseDown += MainPannelM_MouseDown;
            MainPannelM.MouseMove += MainPannelM_MouseMove;
            // 
            // buttonMyCards
            // 
            buttonMyCards.BackColor = Color.Cyan;
            buttonMyCards.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMyCards.Location = new Point(964, 470);
            buttonMyCards.Name = "buttonMyCards";
            buttonMyCards.Size = new Size(300, 50);
            buttonMyCards.TabIndex = 9;
            buttonMyCards.Text = "Мои проекты";
            buttonMyCards.UseVisualStyleBackColor = false;
            buttonMyCards.Click += buttonMyCards_Click;
            // 
            // CreateCard
            // 
            CreateCard.BackColor = Color.Cyan;
            CreateCard.Cursor = Cursors.Hand;
            CreateCard.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            CreateCard.Location = new Point(964, 302);
            CreateCard.Name = "CreateCard";
            CreateCard.Size = new Size(300, 50);
            CreateCard.TabIndex = 8;
            CreateCard.Text = "Создать проект";
            CreateCard.UseVisualStyleBackColor = false;
            CreateCard.Click += CreateCard_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.MediumTurquoise;
            labelLogin.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.Location = new Point(304, 526);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(148, 35);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "labelName";
            // 
            // labelPassport
            // 
            labelPassport.AutoSize = true;
            labelPassport.BackColor = Color.MediumTurquoise;
            labelPassport.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassport.Location = new Point(304, 420);
            labelPassport.Name = "labelPassport";
            labelPassport.Size = new Size(148, 35);
            labelPassport.TabIndex = 6;
            labelPassport.Text = "labelName";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.MediumTurquoise;
            labelName.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(304, 317);
            labelName.Name = "labelName";
            labelName.Size = new Size(148, 35);
            labelName.TabIndex = 5;
            labelName.Text = "labelName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Turquoise;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(382, 190);
            label1.Name = "label1";
            label1.Size = new Size(211, 38);
            label1.TabIndex = 4;
            label1.Text = "Мои данные";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(LabelUserInfo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1600, 125);
            panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.Firebrick;
            CloseButton.Location = new Point(1555, 9);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(33, 35);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            // 
            // LabelUserInfo
            // 
            LabelUserInfo.Dock = DockStyle.Fill;
            LabelUserInfo.Font = new Font("Times New Roman", 40F, FontStyle.Bold, GraphicsUnit.Point);
            LabelUserInfo.Location = new Point(0, 0);
            LabelUserInfo.Name = "LabelUserInfo";
            LabelUserInfo.Size = new Size(1600, 125);
            LabelUserInfo.TabIndex = 0;
            LabelUserInfo.Text = "Личный кабинет";
            LabelUserInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(MainPannelM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            MainPannelM.ResumeLayout(false);
            MainPannelM.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPannelM;
        private Panel panel2;
        private Label CloseButton;
        private Label LabelUserInfo;
        private Label label1;
        private TextBox textBoxLogin;
        private TextBox textBoxPassport;
        private TextBox textBoxName;
        private Label labelLogin;
        private Label labelPassport;
        private Label labelName;
        private Button buttonMyCards;
        private Button CreateCard;
    }
}