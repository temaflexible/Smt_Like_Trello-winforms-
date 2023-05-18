namespace WinFormsApp
{
    partial class AddWorkers
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
            label2 = new Label();
            label1 = new Label();
            WorkersListBox = new TextBox();
            button1 = new Button();
            labelNext = new Label();
            workerLoginBox = new TextBox();
            SelectWorkersLabel = new Label();
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
            MainPannelM.Controls.Add(label2);
            MainPannelM.Controls.Add(label1);
            MainPannelM.Controls.Add(WorkersListBox);
            MainPannelM.Controls.Add(button1);
            MainPannelM.Controls.Add(labelNext);
            MainPannelM.Controls.Add(workerLoginBox);
            MainPannelM.Controls.Add(SelectWorkersLabel);
            MainPannelM.Controls.Add(panel2);
            MainPannelM.Dock = DockStyle.Fill;
            MainPannelM.Location = new Point(0, 0);
            MainPannelM.Name = "MainPannelM";
            MainPannelM.Size = new Size(1600, 900);
            MainPannelM.TabIndex = 3;
            MainPannelM.MouseDown += MainPannelM_MouseDown;
            MainPannelM.MouseMove += MainPannelM_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 255);
            label2.Location = new Point(1029, 343);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(465, 327);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // WorkersListBox
            // 
            WorkersListBox.Location = new Point(631, 407);
            WorkersListBox.Multiline = true;
            WorkersListBox.Name = "WorkersListBox";
            WorkersListBox.Size = new Size(228, 161);
            WorkersListBox.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(877, 327);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 8;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelNext
            // 
            labelNext.AutoSize = true;
            labelNext.BackColor = Color.Lime;
            labelNext.Cursor = Cursors.Hand;
            labelNext.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNext.Location = new Point(884, 536);
            labelNext.Name = "labelNext";
            labelNext.Size = new Size(87, 32);
            labelNext.TabIndex = 7;
            labelNext.Text = "Далее";
            labelNext.Click += labelNext_Click;
            // 
            // workerLoginBox
            // 
            workerLoginBox.Cursor = Cursors.IBeam;
            workerLoginBox.Location = new Point(631, 327);
            workerLoginBox.Multiline = true;
            workerLoginBox.Name = "workerLoginBox";
            workerLoginBox.Size = new Size(228, 39);
            workerLoginBox.TabIndex = 6;
            // 
            // SelectWorkersLabel
            // 
            SelectWorkersLabel.AutoSize = true;
            SelectWorkersLabel.BackColor = Color.Turquoise;
            SelectWorkersLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            SelectWorkersLabel.Location = new Point(631, 253);
            SelectWorkersLabel.Name = "SelectWorkersLabel";
            SelectWorkersLabel.Size = new Size(340, 32);
            SelectWorkersLabel.TabIndex = 5;
            SelectWorkersLabel.Text = "Введите логин работника";
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
            LabelUserInfo.Text = "Конструктор проекта";
            LabelUserInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddWorkers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(MainPannelM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddWorkers";
            Text = "AddWorkers";
            MainPannelM.ResumeLayout(false);
            MainPannelM.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPannelM;
        private TextBox WorkersListBox;
        private Button button1;
        private Label labelNext;
        private TextBox workerLoginBox;
        private Label SelectWorkersLabel;
        private Panel panel2;
        private Label CloseButton;
        private Label LabelUserInfo;
        private Label label1;
        private Label label2;
    }
}