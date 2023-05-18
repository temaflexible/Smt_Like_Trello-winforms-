namespace WinFormsApp
{
    partial class CardEdit
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
            panel2 = new Panel();
            CloseButton = new Label();
            labelCardName = new Label();
            MainPannelM = new Panel();
            buttonConfirmEdit = new Button();
            textBoxCardDesc = new TextBox();
            textBoxCardName = new TextBox();
            button1 = new Button();
            panel2.SuspendLayout();
            MainPannelM.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(labelCardName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 125);
            panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.Firebrick;
            CloseButton.Location = new Point(737, 9);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(33, 35);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            // 
            // labelCardName
            // 
            labelCardName.Dock = DockStyle.Fill;
            labelCardName.Font = new Font("Times New Roman", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelCardName.Location = new Point(0, 0);
            labelCardName.Name = "labelCardName";
            labelCardName.Size = new Size(782, 125);
            labelCardName.TabIndex = 0;
            labelCardName.Text = "Редактор";
            labelCardName.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainPannelM
            // 
            MainPannelM.BackColor = Color.FromArgb(20, 101, 135);
            MainPannelM.Controls.Add(button1);
            MainPannelM.Controls.Add(buttonConfirmEdit);
            MainPannelM.Controls.Add(textBoxCardDesc);
            MainPannelM.Controls.Add(textBoxCardName);
            MainPannelM.Controls.Add(panel2);
            MainPannelM.Dock = DockStyle.Fill;
            MainPannelM.Location = new Point(0, 0);
            MainPannelM.Name = "MainPannelM";
            MainPannelM.Size = new Size(782, 553);
            MainPannelM.TabIndex = 4;
            // 
            // buttonConfirmEdit
            // 
            buttonConfirmEdit.BackColor = Color.FromArgb(128, 255, 128);
            buttonConfirmEdit.Location = new Point(424, 290);
            buttonConfirmEdit.Name = "buttonConfirmEdit";
            buttonConfirmEdit.Size = new Size(196, 29);
            buttonConfirmEdit.TabIndex = 3;
            buttonConfirmEdit.Text = "Подтвердить изменения";
            buttonConfirmEdit.UseVisualStyleBackColor = false;
            buttonConfirmEdit.Click += buttonConfirmEdit_Click;
            // 
            // textBoxCardDesc
            // 
            textBoxCardDesc.Location = new Point(112, 258);
            textBoxCardDesc.Multiline = true;
            textBoxCardDesc.Name = "textBoxCardDesc";
            textBoxCardDesc.Size = new Size(256, 190);
            textBoxCardDesc.TabIndex = 2;
            // 
            // textBoxCardName
            // 
            textBoxCardName.Location = new Point(112, 168);
            textBoxCardName.Multiline = true;
            textBoxCardName.Name = "textBoxCardName";
            textBoxCardName.Size = new Size(256, 34);
            textBoxCardName.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(551, 499);
            button1.Name = "button1";
            button1.Size = new Size(207, 29);
            button1.TabIndex = 4;
            button1.Text = "Вернуться к проекту ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CardEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(MainPannelM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CardEdit";
            Text = "CardEdit";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            MainPannelM.ResumeLayout(false);
            MainPannelM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label CloseButton;
        private Label labelCardName;
        private Panel MainPannelM;
        private Button buttonConfirmEdit;
        private TextBox textBoxCardDesc;
        private TextBox textBoxCardName;
        private Button button1;
    }
}