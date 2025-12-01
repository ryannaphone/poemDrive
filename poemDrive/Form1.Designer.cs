namespace poemDrive
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            displayPanel = new Panel();
            poemListBox = new ListBox();
            controlPanel = new Panel();
            generateButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            settingComboBox = new ComboBox();
            panel2 = new Panel();
            titlesListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            displayPanel.SuspendLayout();
            controlPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._20210614_161751__2_;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1843, 1243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // displayPanel
            // 
            displayPanel.Controls.Add(poemListBox);
            displayPanel.Location = new Point(547, 51);
            displayPanel.Name = "displayPanel";
            displayPanel.Size = new Size(1147, 381);
            displayPanel.TabIndex = 1;
            // 
            // poemListBox
            // 
            poemListBox.FormattingEnabled = true;
            poemListBox.ItemHeight = 41;
            poemListBox.Location = new Point(3, 3);
            poemListBox.Name = "poemListBox";
            poemListBox.Size = new Size(1141, 373);
            poemListBox.TabIndex = 0;
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(generateButton);
            controlPanel.Controls.Add(panel1);
            controlPanel.Controls.Add(label1);
            controlPanel.Controls.Add(settingComboBox);
            controlPanel.Location = new Point(1154, 837);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(441, 319);
            controlPanel.TabIndex = 2;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(13, 249);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(421, 58);
            generateButton.TabIndex = 3;
            generateButton.Text = "Generate Poem";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(13, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 160);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 1;
            label1.Text = "Poem Setting";
            // 
            // settingComboBox
            // 
            settingComboBox.FormattingEnabled = true;
            settingComboBox.Items.AddRange(new object[] { "True Random", "Random Algorithm", "Random Specific", "Specific", "Ultra Specific" });
            settingComboBox.Location = new Point(211, 9);
            settingComboBox.Name = "settingComboBox";
            settingComboBox.Size = new Size(223, 49);
            settingComboBox.TabIndex = 0;
            settingComboBox.Text = "True Random";
            // 
            // panel2
            // 
            panel2.Controls.Add(titlesListBox);
            panel2.Location = new Point(27, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 793);
            panel2.TabIndex = 3;
            // 
            // titlesListBox
            // 
            titlesListBox.FormattingEnabled = true;
            titlesListBox.ItemHeight = 41;
            titlesListBox.Location = new Point(3, 3);
            titlesListBox.Name = "titlesListBox";
            titlesListBox.Size = new Size(494, 783);
            titlesListBox.TabIndex = 0;
            titlesListBox.SelectedIndexChanged += titlesListBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1867, 1267);
            Controls.Add(panel2);
            Controls.Add(controlPanel);
            Controls.Add(displayPanel);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "........ <> ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            displayPanel.ResumeLayout(false);
            controlPanel.ResumeLayout(false);
            controlPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel displayPanel;
        private Panel controlPanel;
        private Label label1;
        private ComboBox settingComboBox;
        private Panel panel1;
        private Button generateButton;
        private ListBox poemListBox;
        private Panel panel2;
        private ListBox titlesListBox;
    }
}
