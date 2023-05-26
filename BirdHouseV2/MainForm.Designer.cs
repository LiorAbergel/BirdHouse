namespace BirdHouseV2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.cageRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.birdRadioButton = new System.Windows.Forms.RadioButton();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.subCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.addBirdButton = new System.Windows.Forms.Button();
            this.addCage = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.CageGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.CageGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(1016, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 51;
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(16, 530);
            this.MaterialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(204, 32);
            this.MaterialComboBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 496);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 418);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Depth";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(17, 451);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightTextBox.Multiline = true;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(203, 39);
            this.HeightTextBox.TabIndex = 12;
            // 
            // cageRadioButton
            // 
            this.cageRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cageRadioButton.AutoSize = true;
            this.cageRadioButton.Location = new System.Drawing.Point(804, 24);
            this.cageRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.cageRadioButton.Name = "cageRadioButton";
            this.cageRadioButton.Size = new System.Drawing.Size(95, 29);
            this.cageRadioButton.TabIndex = 43;
            this.cageRadioButton.TabStop = true;
            this.cageRadioButton.Text = "Cages";
            this.cageRadioButton.UseVisualStyleBackColor = true;
            this.cageRadioButton.Click += new System.EventHandler(this.cageRadioButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Width";
            // 
            // birdRadioButton
            // 
            this.birdRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.birdRadioButton.AutoSize = true;
            this.birdRadioButton.Location = new System.Drawing.Point(804, 61);
            this.birdRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.birdRadioButton.Name = "birdRadioButton";
            this.birdRadioButton.Size = new System.Drawing.Size(81, 29);
            this.birdRadioButton.TabIndex = 44;
            this.birdRadioButton.TabStop = true;
            this.birdRadioButton.Text = "Birds";
            this.birdRadioButton.UseVisualStyleBackColor = true;
            this.birdRadioButton.Click += new System.EventHandler(this.birdRadioButton_Click);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(17, 367);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthTextBox.Multiline = true;
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(203, 39);
            this.WidthTextBox.TabIndex = 10;
            // 
            // subCategoryComboBox
            // 
            this.subCategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subCategoryComboBox.FormattingEnabled = true;
            this.subCategoryComboBox.Location = new System.Drawing.Point(468, 61);
            this.subCategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.subCategoryComboBox.Name = "subCategoryComboBox";
            this.subCategoryComboBox.Size = new System.Drawing.Size(328, 32);
            this.subCategoryComboBox.TabIndex = 45;
            this.subCategoryComboBox.SelectedValueChanged += new System.EventHandler(this.subCategoryComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Length";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(468, 15);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(328, 32);
            this.categoryComboBox.TabIndex = 46;
            this.categoryComboBox.SelectedValueChanged += new System.EventHandler(this.categoryComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Serial";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(359, 21);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 47;
            this.label16.Text = "Category";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(16, 287);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LengthTextBox.Multiline = true;
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(203, 39);
            this.LengthTextBox.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(332, 70);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 25);
            this.label17.TabIndex = 48;
            this.label17.Text = "Sub Category";
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Location = new System.Drawing.Point(17, 206);
            this.SerialNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SerialNumberTextBox.Multiline = true;
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(203, 39);
            this.SerialNumberTextBox.TabIndex = 3;
            // 
            // addBirdButton
            // 
            this.addBirdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBirdButton.Location = new System.Drawing.Point(1016, 81);
            this.addBirdButton.Margin = new System.Windows.Forms.Padding(2);
            this.addBirdButton.Name = "addBirdButton";
            this.addBirdButton.Size = new System.Drawing.Size(152, 60);
            this.addBirdButton.TabIndex = 49;
            this.addBirdButton.Text = "Add Birds";
            this.addBirdButton.UseVisualStyleBackColor = true;
            this.addBirdButton.Click += new System.EventHandler(this.addBirdButton_Click);
            // 
            // addCage
            // 
            this.addCage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCage.Location = new System.Drawing.Point(16, 581);
            this.addCage.Margin = new System.Windows.Forms.Padding(2);
            this.addCage.Name = "addCage";
            this.addCage.Size = new System.Drawing.Size(198, 82);
            this.addCage.TabIndex = 2;
            this.addCage.Text = "Add Cage";
            this.addCage.UseVisualStyleBackColor = true;
            this.addCage.Click += new System.EventHandler(this.addCage_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.Location = new System.Drawing.Point(550, 99);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(167, 45);
            this.searchButton.TabIndex = 50;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CageGridView
            // 
            this.CageGridView.AllowUserToOrderColumns = true;
            this.CageGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CageGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CageGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CageGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.CageGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CageGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.CageGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CageGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CageGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CageGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.CageGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.CageGridView.Location = new System.Drawing.Point(203, 150);
            this.CageGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CageGridView.MultiSelect = false;
            this.CageGridView.Name = "CageGridView";
            this.CageGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CageGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CageGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CageGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.CageGridView.RowTemplate.Height = 28;
            this.CageGridView.Size = new System.Drawing.Size(978, 535);
            this.CageGridView.TabIndex = 17;
            this.CageGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CageGridView_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.CageGridView);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.addBirdButton);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.subCategoryComboBox);
            this.panel1.Controls.Add(this.birdRadioButton);
            this.panel1.Controls.Add(this.cageRadioButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 674);
            this.panel1.TabIndex = 51;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.addCage);
            this.panel3.Controls.Add(this.MaterialComboBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.SerialNumberTextBox);
            this.panel3.Controls.Add(this.HeightTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.LengthTextBox);
            this.panel3.Controls.Add(this.WidthTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 674);
            this.panel3.TabIndex = 52;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(-13, -13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 165);
            this.panel4.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Create a Cage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BirdHouseV2.Properties.Resources.cageIcon;
            this.pictureBox1.Location = new System.Drawing.Point(47, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(234, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 674);
            this.splitter1.TabIndex = 53;
            this.splitter1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1179, 674);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(996, 738);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CageGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.RadioButton cageRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton birdRadioButton;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.ComboBox subCategoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private System.Windows.Forms.Button addBirdButton;
        private System.Windows.Forms.Button addCage;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView CageGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Splitter splitter1;
    }
}

