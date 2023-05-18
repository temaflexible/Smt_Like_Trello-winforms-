namespace WinFormsApp
{
    partial class MyCards
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
            labelSelectProj = new TextBox();
            button1 = new Button();
            dataGridViewWorker = new DataGridView();
            dataGridViewLeader = new DataGridView();
            labelWorker = new Label();
            labelLeader = new Label();
            panel2 = new Panel();
            CloseButton = new Label();
            LabelUserInfo = new Label();
            buttonReturnToMain = new Button();
            MainPannelM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeader).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPannelM
            // 
            MainPannelM.BackColor = Color.FromArgb(20, 101, 135);
            MainPannelM.Controls.Add(buttonReturnToMain);
            MainPannelM.Controls.Add(labelSelectProj);
            MainPannelM.Controls.Add(button1);
            MainPannelM.Controls.Add(dataGridViewWorker);
            MainPannelM.Controls.Add(dataGridViewLeader);
            MainPannelM.Controls.Add(labelWorker);
            MainPannelM.Controls.Add(labelLeader);
            MainPannelM.Controls.Add(panel2);
            MainPannelM.Dock = DockStyle.Fill;
            MainPannelM.Location = new Point(0, 0);
            MainPannelM.Name = "MainPannelM";
            MainPannelM.Size = new Size(1600, 900);
            MainPannelM.TabIndex = 2;
            MainPannelM.MouseDown += MainPannelM_MouseDown;
            MainPannelM.MouseMove += MainPannelM_MouseMove;
            // 
            // labelSelectProj
            // 
            labelSelectProj.BackColor = Color.FromArgb(20, 101, 135);
            labelSelectProj.Location = new Point(1105, 385);
            labelSelectProj.Multiline = true;
            labelSelectProj.Name = "labelSelectProj";
            labelSelectProj.ReadOnly = true;
            labelSelectProj.Size = new Size(144, 46);
            labelSelectProj.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1105, 458);
            button1.Name = "button1";
            button1.Size = new Size(144, 44);
            button1.TabIndex = 5;
            button1.Text = "Открыть";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewWorker
            // 
            dataGridViewWorker.BackgroundColor = Color.FromArgb(20, 101, 135);
            dataGridViewWorker.BorderStyle = BorderStyle.None;
            dataGridViewWorker.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorker.GridColor = Color.DarkGray;
            dataGridViewWorker.Location = new Point(715, 315);
            dataGridViewWorker.Name = "dataGridViewWorker";
            dataGridViewWorker.RowHeadersWidth = 51;
            dataGridViewWorker.RowTemplate.Height = 29;
            dataGridViewWorker.Size = new Size(223, 259);
            dataGridViewWorker.TabIndex = 4;
            dataGridViewWorker.CellClick += dataGridViewWorker_CellClick;
            // 
            // dataGridViewLeader
            // 
            dataGridViewLeader.BackgroundColor = Color.FromArgb(20, 101, 135);
            dataGridViewLeader.BorderStyle = BorderStyle.None;
            dataGridViewLeader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLeader.Location = new Point(335, 315);
            dataGridViewLeader.Name = "dataGridViewLeader";
            dataGridViewLeader.RowHeadersWidth = 51;
            dataGridViewLeader.RowTemplate.Height = 29;
            dataGridViewLeader.Size = new Size(223, 259);
            dataGridViewLeader.TabIndex = 3;
            dataGridViewLeader.CellClick += dataGridViewLeader_CellClick;
            // 
            // labelWorker
            // 
            labelWorker.AutoSize = true;
            labelWorker.BackColor = Color.Turquoise;
            labelWorker.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelWorker.Location = new Point(747, 200);
            labelWorker.Name = "labelWorker";
            labelWorker.Size = new Size(159, 32);
            labelWorker.TabIndex = 2;
            labelWorker.Text = "Я участник";
            // 
            // labelLeader
            // 
            labelLeader.AutoSize = true;
            labelLeader.BackColor = Color.Turquoise;
            labelLeader.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelLeader.Location = new Point(376, 200);
            labelLeader.Name = "labelLeader";
            labelLeader.Size = new Size(115, 32);
            labelLeader.TabIndex = 1;
            labelLeader.Text = "Я лидер";
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
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // LabelUserInfo
            // 
            LabelUserInfo.Dock = DockStyle.Fill;
            LabelUserInfo.Font = new Font("Times New Roman", 40F, FontStyle.Bold, GraphicsUnit.Point);
            LabelUserInfo.Location = new Point(0, 0);
            LabelUserInfo.Name = "LabelUserInfo";
            LabelUserInfo.Size = new Size(1600, 125);
            LabelUserInfo.TabIndex = 0;
            LabelUserInfo.Text = "Мои проекты";
            LabelUserInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonReturnToMain
            // 
            buttonReturnToMain.BackColor = Color.FromArgb(128, 255, 128);
            buttonReturnToMain.Location = new Point(39, 156);
            buttonReturnToMain.Name = "buttonReturnToMain";
            buttonReturnToMain.Size = new Size(193, 29);
            buttonReturnToMain.TabIndex = 14;
            buttonReturnToMain.Text = "Вернуться на гланую";
            buttonReturnToMain.UseVisualStyleBackColor = false;
            buttonReturnToMain.Click += buttonReturnToMain_Click;
            // 
            // MyCards
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(MainPannelM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyCards";
            Text = "MyCards";
            MainPannelM.ResumeLayout(false);
            MainPannelM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorker).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeader).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPannelM;
        private Button button1;
        private DataGridView dataGridViewWorker;
        private DataGridView dataGridViewLeader;
        private Label labelWorker;
        private Label labelLeader;
        private Panel panel2;
        private Label CloseButton;
        private Label LabelUserInfo;
        private TextBox labelSelectProj;
        private Button buttonReturnToMain;
    }
}