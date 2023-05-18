namespace WinFormsApp
{
    partial class AddTasks
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
            buttonAddWorker = new Button();
            buttonAddTask = new Button();
            dataGridView = new DataGridView();
            label3 = new Label();
            WorkerLoginBox = new TextBox();
            label2 = new Label();
            labelNext = new Label();
            DescriptionBox = new TextBox();
            label1 = new Label();
            SelectTaskNameBox = new TextBox();
            SelectNameLabel = new Label();
            panel2 = new Panel();
            CloseButton = new Label();
            LabelUserInfo = new Label();
            MainPannelM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPannelM
            // 
            MainPannelM.BackColor = Color.FromArgb(20, 101, 135);
            MainPannelM.Controls.Add(buttonAddWorker);
            MainPannelM.Controls.Add(buttonAddTask);
            MainPannelM.Controls.Add(dataGridView);
            MainPannelM.Controls.Add(label3);
            MainPannelM.Controls.Add(WorkerLoginBox);
            MainPannelM.Controls.Add(label2);
            MainPannelM.Controls.Add(labelNext);
            MainPannelM.Controls.Add(DescriptionBox);
            MainPannelM.Controls.Add(label1);
            MainPannelM.Controls.Add(SelectTaskNameBox);
            MainPannelM.Controls.Add(SelectNameLabel);
            MainPannelM.Controls.Add(panel2);
            MainPannelM.Dock = DockStyle.Fill;
            MainPannelM.Location = new Point(0, 0);
            MainPannelM.Name = "MainPannelM";
            MainPannelM.Size = new Size(1600, 900);
            MainPannelM.TabIndex = 3;
            MainPannelM.MouseDown += MainPannelM_MouseDown;
            MainPannelM.MouseMove += MainPannelM_MouseMove;
            // 
            // buttonAddWorker
            // 
            buttonAddWorker.BackColor = Color.FromArgb(128, 255, 128);
            buttonAddWorker.Location = new Point(1277, 275);
            buttonAddWorker.Name = "buttonAddWorker";
            buttonAddWorker.Size = new Size(184, 29);
            buttonAddWorker.TabIndex = 14;
            buttonAddWorker.Text = "Добавить работника";
            buttonAddWorker.UseVisualStyleBackColor = false;
            buttonAddWorker.Click += buttonAddWorker_Click;
            // 
            // buttonAddTask
            // 
            buttonAddTask.BackColor = Color.FromArgb(128, 255, 128);
            buttonAddTask.Location = new Point(612, 550);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(170, 29);
            buttonAddTask.TabIndex = 13;
            buttonAddTask.Text = "Добавить задачу";
            buttonAddTask.UseVisualStyleBackColor = false;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.FromArgb(20, 101, 135);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Cursor = Cursors.IBeam;
            dataGridView.GridColor = Color.FromArgb(20, 101, 135);
            dataGridView.Location = new Point(1027, 402);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(184, 276);
            dataGridView.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Turquoise;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(944, 345);
            label3.Name = "label3";
            label3.Size = new Size(315, 32);
            label3.TabIndex = 11;
            label3.Text = "Работают над проектом";
            // 
            // WorkerLoginBox
            // 
            WorkerLoginBox.Location = new Point(981, 265);
            WorkerLoginBox.Multiline = true;
            WorkerLoginBox.Name = "WorkerLoginBox";
            WorkerLoginBox.Size = new Size(226, 39);
            WorkerLoginBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Turquoise;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1027, 191);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 8;
            label2.Text = "Работник ";
            // 
            // labelNext
            // 
            labelNext.AutoSize = true;
            labelNext.BackColor = Color.Lime;
            labelNext.Cursor = Cursors.Hand;
            labelNext.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNext.Location = new Point(1331, 646);
            labelNext.Name = "labelNext";
            labelNext.Size = new Size(155, 32);
            labelNext.TabIndex = 7;
            labelNext.Text = "Завершить";
            labelNext.Click += labelNext_Click;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Cursor = Cursors.IBeam;
            DescriptionBox.Location = new Point(249, 402);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(343, 276);
            DescriptionBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Turquoise;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(301, 345);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 3;
            label1.Text = "Описание цели";
            // 
            // SelectTaskNameBox
            // 
            SelectTaskNameBox.Cursor = Cursors.IBeam;
            SelectTaskNameBox.Location = new Point(301, 265);
            SelectTaskNameBox.Multiline = true;
            SelectTaskNameBox.Name = "SelectTaskNameBox";
            SelectTaskNameBox.Size = new Size(221, 39);
            SelectTaskNameBox.TabIndex = 2;
            // 
            // SelectNameLabel
            // 
            SelectNameLabel.AutoSize = true;
            SelectNameLabel.BackColor = Color.Turquoise;
            SelectNameLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            SelectNameLabel.Location = new Point(301, 191);
            SelectNameLabel.Name = "SelectNameLabel";
            SelectNameLabel.Size = new Size(225, 32);
            SelectNameLabel.TabIndex = 1;
            SelectNameLabel.Text = "Название задачи";
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
            // AddTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(MainPannelM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTasks";
            Text = "AddTasks";
            MainPannelM.ResumeLayout(false);
            MainPannelM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPannelM;
        private Label labelNext;
        private TextBox DescriptionBox;
        private Label label1;
        private TextBox SelectTaskNameBox;
        private Label SelectNameLabel;
        private Panel panel2;
        private Label CloseButton;
        private Label LabelUserInfo;
        private Label label2;
        private DataGridView dataGridView;
        private Label label3;
        private TextBox WorkerLoginBox;
        private Button buttonAddWorker;
        private Button buttonAddTask;
    }
}