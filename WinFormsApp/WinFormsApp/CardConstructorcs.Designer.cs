namespace WinFormsApp
{
    partial class CardConstructorcs
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
            labelNext = new Label();
            DescriptionBox = new TextBox();
            label1 = new Label();
            SelectcardNameBox = new TextBox();
            SelectNameLabel = new Label();
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
            MainPannelM.Controls.Add(labelNext);
            MainPannelM.Controls.Add(DescriptionBox);
            MainPannelM.Controls.Add(label1);
            MainPannelM.Controls.Add(SelectcardNameBox);
            MainPannelM.Controls.Add(SelectNameLabel);
            MainPannelM.Controls.Add(panel2);
            MainPannelM.Dock = DockStyle.Fill;
            MainPannelM.Location = new Point(0, 0);
            MainPannelM.Name = "MainPannelM";
            MainPannelM.Size = new Size(1600, 900);
            MainPannelM.TabIndex = 2;
            // 
            // labelNext
            // 
            labelNext.AutoSize = true;
            labelNext.BackColor = Color.Lime;
            labelNext.Cursor = Cursors.Hand;
            labelNext.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNext.Location = new Point(1070, 578);
            labelNext.Name = "labelNext";
            labelNext.Size = new Size(87, 32);
            labelNext.TabIndex = 7;
            labelNext.Text = "Далее";
            labelNext.Click += labelNext_Click;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Cursor = Cursors.IBeam;
            DescriptionBox.Location = new Point(494, 404);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(479, 276);
            DescriptionBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Turquoise;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(638, 347);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 3;
            label1.Text = "Описание цели";
            label1.Click += label1_Click;
            // 
            // SelectcardNameBox
            // 
            SelectcardNameBox.Cursor = Cursors.IBeam;
            SelectcardNameBox.Location = new Point(638, 267);
            SelectcardNameBox.Multiline = true;
            SelectcardNameBox.Name = "SelectcardNameBox";
            SelectcardNameBox.Size = new Size(221, 39);
            SelectcardNameBox.TabIndex = 2;
            SelectcardNameBox.TextChanged += SelectcardNameBox_TextChanged;
            // 
            // SelectNameLabel
            // 
            SelectNameLabel.AutoSize = true;
            SelectNameLabel.BackColor = Color.Turquoise;
            SelectNameLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            SelectNameLabel.Location = new Point(638, 193);
            SelectNameLabel.Name = "SelectNameLabel";
            SelectNameLabel.Size = new Size(243, 32);
            SelectNameLabel.TabIndex = 1;
            SelectNameLabel.Text = "Название проекта";
            SelectNameLabel.Click += SelectNameLabel_Click;
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
            LabelUserInfo.Text = "Конструктор проекта";
            LabelUserInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // CardConstructorcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(MainPannelM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CardConstructorcs";
            Text = "CardConstructorcs";
            MainPannelM.ResumeLayout(false);
            MainPannelM.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPannelM;
        private TextBox DescriptionBox;
        private Label label1;
        private TextBox SelectcardNameBox;
        private Label SelectNameLabel;
        private Panel panel2;
        private Label CloseButton;
        private Label LabelUserInfo;
        private Label labelNext;
    }
}