namespace WinFormsApp
{
    partial class CardView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            MainPannelM = new Panel();
            button2 = new Button();
            buttonTaskCompleted = new Button();
            textBoxTaskToDoName = new TextBox();
            button1 = new Button();
            textBoxTaskName = new TextBox();
            dataGridViewTaskToDO = new DataGridView();
            label1 = new Label();
            labelCompletedTasks = new Label();
            labelTasks = new Label();
            labelCardInfo = new Label();
            dataGridViewTasksDone = new DataGridView();
            dataGridViewTasks = new DataGridView();
            dataGridViewProj = new DataGridView();
            panel2 = new Panel();
            CloseButton = new Label();
            labelCardName = new Label();
            buttonCardEdit = new Button();
            MainPannelM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaskToDO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasksDone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProj).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPannelM
            // 
            MainPannelM.BackColor = Color.FromArgb(20, 101, 135);
            MainPannelM.Controls.Add(buttonCardEdit);
            MainPannelM.Controls.Add(button2);
            MainPannelM.Controls.Add(buttonTaskCompleted);
            MainPannelM.Controls.Add(textBoxTaskToDoName);
            MainPannelM.Controls.Add(button1);
            MainPannelM.Controls.Add(textBoxTaskName);
            MainPannelM.Controls.Add(dataGridViewTaskToDO);
            MainPannelM.Controls.Add(label1);
            MainPannelM.Controls.Add(labelCompletedTasks);
            MainPannelM.Controls.Add(labelTasks);
            MainPannelM.Controls.Add(labelCardInfo);
            MainPannelM.Controls.Add(dataGridViewTasksDone);
            MainPannelM.Controls.Add(dataGridViewTasks);
            MainPannelM.Controls.Add(dataGridViewProj);
            MainPannelM.Controls.Add(panel2);
            MainPannelM.Dock = DockStyle.Fill;
            MainPannelM.Location = new Point(0, 0);
            MainPannelM.Name = "MainPannelM";
            MainPannelM.Size = new Size(1900, 1000);
            MainPannelM.TabIndex = 3;
            MainPannelM.Paint += MainPannelM_Paint;
            MainPannelM.MouseDown += MainPannelM_MouseDown;
            MainPannelM.MouseMove += MainPannelM_MouseMove;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(82, 142);
            button2.Name = "button2";
            button2.Size = new Size(193, 29);
            button2.TabIndex = 13;
            button2.Text = "Вернуться на гланую";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonTaskCompleted
            // 
            buttonTaskCompleted.BackColor = Color.FromArgb(128, 255, 128);
            buttonTaskCompleted.Location = new Point(1636, 436);
            buttonTaskCompleted.Name = "buttonTaskCompleted";
            buttonTaskCompleted.Size = new Size(243, 29);
            buttonTaskCompleted.TabIndex = 12;
            buttonTaskCompleted.Text = " Завершить выполнение";
            buttonTaskCompleted.UseVisualStyleBackColor = false;
            buttonTaskCompleted.Click += buttonTaskCompleted_Click;
            // 
            // textBoxTaskToDoName
            // 
            textBoxTaskToDoName.Location = new Point(1636, 366);
            textBoxTaskToDoName.Multiline = true;
            textBoxTaskToDoName.Name = "textBoxTaskToDoName";
            textBoxTaskToDoName.ReadOnly = true;
            textBoxTaskToDoName.Size = new Size(243, 34);
            textBoxTaskToDoName.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(366, 931);
            button1.Name = "button1";
            button1.Size = new Size(243, 29);
            button1.TabIndex = 10;
            button1.Text = "Начать выполнение";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(366, 866);
            textBoxTaskName.Multiline = true;
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.ReadOnly = true;
            textBoxTaskName.Size = new Size(243, 34);
            textBoxTaskName.TabIndex = 9;
            // 
            // dataGridViewTaskToDO
            // 
            dataGridViewTaskToDO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTaskToDO.BackgroundColor = Color.FromArgb(20, 101, 135);
            dataGridViewTaskToDO.BorderStyle = BorderStyle.None;
            dataGridViewTaskToDO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaskToDO.Location = new Point(928, 202);
            dataGridViewTaskToDO.Name = "dataGridViewTaskToDO";
            dataGridViewTaskToDO.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewTaskToDO.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTaskToDO.RowHeadersWidth = 51;
            dataGridViewTaskToDO.RowTemplate.Height = 29;
            dataGridViewTaskToDO.Size = new Size(670, 308);
            dataGridViewTaskToDO.TabIndex = 8;
            dataGridViewTaskToDO.CellClick += dataGridViewTaskToDO_CellClick;
            dataGridViewTaskToDO.CellContentClick += dataGridViewTaskToDO_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Turquoise;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1074, 123);
            label1.Name = "label1";
            label1.Size = new Size(305, 32);
            label1.TabIndex = 7;
            label1.Text = "Задачи на выполнении";
            label1.Click += label1_Click;
            // 
            // labelCompletedTasks
            // 
            labelCompletedTasks.AutoSize = true;
            labelCompletedTasks.BackColor = Color.Turquoise;
            labelCompletedTasks.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelCompletedTasks.Location = new Point(1074, 522);
            labelCompletedTasks.Name = "labelCompletedTasks";
            labelCompletedTasks.Size = new Size(287, 32);
            labelCompletedTasks.TabIndex = 6;
            labelCompletedTasks.Text = "Выполненные задачи";
            // 
            // labelTasks
            // 
            labelTasks.AutoSize = true;
            labelTasks.BackColor = Color.Turquoise;
            labelTasks.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTasks.Location = new Point(497, 441);
            labelTasks.Name = "labelTasks";
            labelTasks.Size = new Size(102, 32);
            labelTasks.TabIndex = 5;
            labelTasks.Text = "Задачи";
            // 
            // labelCardInfo
            // 
            labelCardInfo.AutoSize = true;
            labelCardInfo.BackColor = Color.Turquoise;
            labelCardInfo.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelCardInfo.Location = new Point(497, 142);
            labelCardInfo.Name = "labelCardInfo";
            labelCardInfo.Size = new Size(108, 32);
            labelCardInfo.TabIndex = 4;
            labelCardInfo.Text = "Проект";
            // 
            // dataGridViewTasksDone
            // 
            dataGridViewTasksDone.BackgroundColor = Color.FromArgb(20, 101, 135);
            dataGridViewTasksDone.BorderStyle = BorderStyle.None;
            dataGridViewTasksDone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasksDone.Location = new Point(928, 568);
            dataGridViewTasksDone.Name = "dataGridViewTasksDone";
            dataGridViewTasksDone.RowHeadersWidth = 51;
            dataGridViewTasksDone.RowTemplate.Height = 29;
            dataGridViewTasksDone.Size = new Size(669, 378);
            dataGridViewTasksDone.TabIndex = 3;
            dataGridViewTasksDone.CellContentClick += dataGridViewTasksDone_CellContentClick;
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.BackgroundColor = Color.FromArgb(20, 101, 135);
            dataGridViewTasks.BorderStyle = BorderStyle.None;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(273, 476);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.RowHeadersWidth = 51;
            dataGridViewTasks.RowTemplate.Height = 29;
            dataGridViewTasks.Size = new Size(611, 349);
            dataGridViewTasks.TabIndex = 2;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;
            // 
            // dataGridViewProj
            // 
            dataGridViewProj.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProj.BackgroundColor = Color.FromArgb(20, 101, 135);
            dataGridViewProj.BorderStyle = BorderStyle.None;
            dataGridViewProj.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProj.Location = new Point(273, 202);
            dataGridViewProj.Name = "dataGridViewProj";
            dataGridViewProj.ReadOnly = true;
            dataGridViewProj.RowHeadersWidth = 51;
            dataGridViewProj.RowTemplate.Height = 29;
            dataGridViewProj.Size = new Size(611, 198);
            dataGridViewProj.TabIndex = 1;
            dataGridViewProj.CellContentClick += dataGridViewProj_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(labelCardName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 125);
            panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.Firebrick;
            CloseButton.Location = new Point(1855, 9);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(33, 35);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // labelCardName
            // 
            labelCardName.Dock = DockStyle.Fill;
            labelCardName.Font = new Font("Times New Roman", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelCardName.Location = new Point(0, 0);
            labelCardName.Name = "labelCardName";
            labelCardName.Size = new Size(1900, 125);
            labelCardName.TabIndex = 0;
            labelCardName.Text = "Мои проекты";
            labelCardName.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonCardEdit
            // 
            buttonCardEdit.BackColor = Color.FromArgb(192, 255, 192);
            buttonCardEdit.Location = new Point(672, 145);
            buttonCardEdit.Name = "buttonCardEdit";
            buttonCardEdit.Size = new Size(122, 29);
            buttonCardEdit.TabIndex = 14;
            buttonCardEdit.Text = "редактировать";
            buttonCardEdit.UseVisualStyleBackColor = false;
            buttonCardEdit.Click += buttonCardEdit_Click;
            // 
            // CardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 1000);
            Controls.Add(MainPannelM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CardView";
            Text = "CardView";
            MainPannelM.ResumeLayout(false);
            MainPannelM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaskToDO).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasksDone).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProj).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPannelM;
        private Panel panel2;
        private Label CloseButton;
        private Label labelCardName;
        private DataGridView dataGridViewTaskToDO;
        private Label label1;
        private Label labelCompletedTasks;
        private Label labelTasks;
        private Label labelCardInfo;
        private DataGridView dataGridViewTasksDone;
        private DataGridView dataGridViewTasks;
        private DataGridView dataGridViewProj;
        private Button button1;
        private TextBox textBoxTaskName;
        private Button buttonTaskCompleted;
        private TextBox textBoxTaskToDoName;
        private Button button2;
        private Button buttonCardEdit;
    }
}