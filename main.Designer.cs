namespace OfflineUsbRepair
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.MenuText;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Cursor = Cursors.Hand;
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            richTextBox1.ForeColor = Color.FromArgb(0, 192, 0);
            richTextBox1.Location = new Point(12, 89);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBox1.Size = new Size(514, 220);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(12, 33);
            button1.Name = "button1";
            button1.Size = new Size(149, 41);
            button1.TabIndex = 1;
            button1.Text = "Diskleri Listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 12);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 2;
            label1.Text = "2) Offline Olan Diski Seç:";
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point(366, 33);
            button2.Name = "button2";
            button2.Size = new Size(162, 41);
            button2.TabIndex = 4;
            button2.Text = "Online Yap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 5;
            label2.Text = "1) Diskleri Tarat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 12);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 6;
            label3.Text = "3) Diski Online Duruma Getir";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(535, 321);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            ForeColor = SystemColors.ButtonHighlight;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "main";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "USB ONLINER";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}
