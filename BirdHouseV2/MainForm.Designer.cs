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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cageRadioButton = new System.Windows.Forms.RadioButton();
            this.birdRadioButton = new System.Windows.Forms.RadioButton();
            this.subCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.addBirdButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.CageGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.addCage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CageGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(865, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 51;
            // 
            // cageRadioButton
            // 
            this.cageRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cageRadioButton.AutoSize = true;
            this.cageRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cageRadioButton.Location = new System.Drawing.Point(731, 19);
            this.cageRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.cageRadioButton.Name = "cageRadioButton";
            this.cageRadioButton.Size = new System.Drawing.Size(95, 29);
            this.cageRadioButton.TabIndex = 43;
            this.cageRadioButton.TabStop = true;
            this.cageRadioButton.Text = "Cages";
            this.cageRadioButton.UseVisualStyleBackColor = true;
            this.cageRadioButton.Click += new System.EventHandler(this.cageRadioButton_Click);
            // 
            // birdRadioButton
            // 
            this.birdRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.birdRadioButton.AutoSize = true;
            this.birdRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birdRadioButton.Location = new System.Drawing.Point(731, 56);
            this.birdRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.birdRadioButton.Name = "birdRadioButton";
            this.birdRadioButton.Size = new System.Drawing.Size(81, 29);
            this.birdRadioButton.TabIndex = 44;
            this.birdRadioButton.TabStop = true;
            this.birdRadioButton.Text = "Birds";
            this.birdRadioButton.UseVisualStyleBackColor = true;
            this.birdRadioButton.Click += new System.EventHandler(this.birdRadioButton_Click);
            // 
            // subCategoryComboBox
            // 
            this.subCategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subCategoryComboBox.FormattingEnabled = true;
            this.subCategoryComboBox.Location = new System.Drawing.Point(395, 56);
            this.subCategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.subCategoryComboBox.Name = "subCategoryComboBox";
            this.subCategoryComboBox.Size = new System.Drawing.Size(328, 32);
            this.subCategoryComboBox.TabIndex = 45;
            this.subCategoryComboBox.SelectedValueChanged += new System.EventHandler(this.subCategoryComboBox_SelectedValueChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(395, 10);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(328, 32);
            this.categoryComboBox.TabIndex = 46;
            this.categoryComboBox.SelectedValueChanged += new System.EventHandler(this.categoryComboBox_SelectedValueChanged);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(286, 16);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 47;
            this.label16.Text = "Category";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(259, 65);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 25);
            this.label17.TabIndex = 48;
            this.label17.Text = "Sub Category";
            // 
            // addBirdButton
            // 
            this.addBirdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBirdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBirdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBirdButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addBirdButton.Location = new System.Drawing.Point(865, 94);
            this.addBirdButton.Margin = new System.Windows.Forms.Padding(2);
            this.addBirdButton.Name = "addBirdButton";
            this.addBirdButton.Size = new System.Drawing.Size(152, 44);
            this.addBirdButton.TabIndex = 49;
            this.addBirdButton.Text = "Add Birds";
            this.addBirdButton.UseVisualStyleBackColor = true;
            this.addBirdButton.Click += new System.EventHandler(this.addBirdButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Location = new System.Drawing.Point(477, 94);
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
            this.CageGridView.AllowUserToAddRows = false;
            this.CageGridView.AllowUserToDeleteRows = false;
            this.CageGridView.AllowUserToResizeColumns = false;
            this.CageGridView.AllowUserToResizeRows = false;
            this.CageGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CageGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CageGridView.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CageGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CageGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CageGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.CageGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CageGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CageGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CageGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CageGridView.EnableHeadersVisualStyles = false;
            this.CageGridView.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.CageGridView.Location = new System.Drawing.Point(253, 148);
            this.CageGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CageGridView.MultiSelect = false;
            this.CageGridView.Name = "CageGridView";
            this.CageGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CageGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CageGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CageGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CageGridView.RowTemplate.Height = 28;
            this.CageGridView.Size = new System.Drawing.Size(777, 535);
            this.CageGridView.TabIndex = 17;
            this.CageGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CageGridView_RowHeaderMouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = global::BirdHouseV2.Properties.Resources.background_2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.addCage);
            this.panel3.Controls.Add(this.MaterialComboBox);
            this.panel3.Controls.Add(this.pictureBox1);
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
            this.panel3.Size = new System.Drawing.Size(254, 674);
            this.panel3.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Serial";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Length";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WidthTextBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.WidthTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.WidthTextBox.Location = new System.Drawing.Point(26, 366);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthTextBox.Multiline = true;
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(203, 39);
            this.WidthTextBox.TabIndex = 10;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LengthTextBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.LengthTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LengthTextBox.Location = new System.Drawing.Point(25, 286);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LengthTextBox.Multiline = true;
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(203, 39);
            this.LengthTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Width";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightTextBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.HeightTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.HeightTextBox.Location = new System.Drawing.Point(26, 450);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightTextBox.Multiline = true;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(203, 39);
            this.HeightTextBox.TabIndex = 12;
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SerialNumberTextBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.SerialNumberTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SerialNumberTextBox.Location = new System.Drawing.Point(26, 205);
            this.SerialNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SerialNumberTextBox.Multiline = true;
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(203, 39);
            this.SerialNumberTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(26, 417);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Depth";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(25, 495);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Material";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaterialComboBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.MaterialComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaterialComboBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(25, 529);
            this.MaterialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(204, 32);
            this.MaterialComboBox.TabIndex = 16;
            // 
            // addCage
            // 
            this.addCage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addCage.BackColor = System.Drawing.Color.Transparent;
            this.addCage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addCage.Location = new System.Drawing.Point(25, 580);
            this.addCage.Margin = new System.Windows.Forms.Padding(2);
            this.addCage.Name = "addCage";
            this.addCage.Size = new System.Drawing.Size(198, 67);
            this.addCage.TabIndex = 2;
            this.addCage.Text = "Add Cage";
            this.addCage.UseVisualStyleBackColor = false;
            this.addCage.Click += new System.EventHandler(this.addCage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BirdHouseV2.Properties.Resources.cageIcon;
            this.pictureBox1.Location = new System.Drawing.Point(41, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Create a Cage";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.addBirdButton);
            this.panel1.Controls.Add(this.CageGridView);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.subCategoryComboBox);
            this.panel1.Controls.Add(this.cageRadioButton);
            this.panel1.Controls.Add(this.birdRadioButton);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 674);
            this.panel1.TabIndex = 51;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1028, 674);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(996, 738);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CageGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton cageRadioButton;
        private System.Windows.Forms.RadioButton birdRadioButton;
        private System.Windows.Forms.ComboBox subCategoryComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button addBirdButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView CageGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addCage;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

