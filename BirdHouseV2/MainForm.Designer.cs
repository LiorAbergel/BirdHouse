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
            this.OpenCageButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.CageGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.addCage = new System.Windows.Forms.Button();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditCageButton = new System.Windows.Forms.Button();
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
            this.panel2.Location = new System.Drawing.Point(695, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 51;
            // 
            // cageRadioButton
            // 
            this.cageRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cageRadioButton.AutoSize = true;
            this.cageRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cageRadioButton.Location = new System.Drawing.Point(604, 16);
            this.cageRadioButton.Name = "cageRadioButton";
            this.cageRadioButton.Size = new System.Drawing.Size(80, 24);
            this.cageRadioButton.TabIndex = 43;
            this.cageRadioButton.TabStop = true;
            this.cageRadioButton.Text = "Cages";
            this.cageRadioButton.UseVisualStyleBackColor = true;
            this.cageRadioButton.Click += new System.EventHandler(this.CageRadioButton_Click);
            // 
            // birdRadioButton
            // 
            this.birdRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.birdRadioButton.AutoSize = true;
            this.birdRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birdRadioButton.Location = new System.Drawing.Point(604, 48);
            this.birdRadioButton.Name = "birdRadioButton";
            this.birdRadioButton.Size = new System.Drawing.Size(70, 24);
            this.birdRadioButton.TabIndex = 44;
            this.birdRadioButton.TabStop = true;
            this.birdRadioButton.Text = "Birds";
            this.birdRadioButton.UseVisualStyleBackColor = true;
            this.birdRadioButton.Click += new System.EventHandler(this.BirdRadioButton_Click);
            // 
            // subCategoryComboBox
            // 
            this.subCategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subCategoryComboBox.FormattingEnabled = true;
            this.subCategoryComboBox.Location = new System.Drawing.Point(316, 48);
            this.subCategoryComboBox.Name = "subCategoryComboBox";
            this.subCategoryComboBox.Size = new System.Drawing.Size(282, 28);
            this.subCategoryComboBox.TabIndex = 45;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(316, 9);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(282, 28);
            this.categoryComboBox.TabIndex = 46;
            this.categoryComboBox.SelectedValueChanged += new System.EventHandler(this.CategoryComboBox_SelectedValueChanged);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(222, 14);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 20);
            this.label16.TabIndex = 47;
            this.label16.Text = "Category";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(199, 56);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 20);
            this.label17.TabIndex = 48;
            this.label17.Text = "Sub Category";
            // 
            // OpenCageButton
            // 
            this.OpenCageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenCageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenCageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenCageButton.Location = new System.Drawing.Point(695, 84);
            this.OpenCageButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenCageButton.Name = "OpenCageButton";
            this.OpenCageButton.Size = new System.Drawing.Size(130, 38);
            this.OpenCageButton.TabIndex = 49;
            this.OpenCageButton.Text = "Open Cage";
            this.OpenCageButton.UseVisualStyleBackColor = true;
            this.OpenCageButton.Click += new System.EventHandler(this.OpenCageButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Location = new System.Drawing.Point(394, 84);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(143, 39);
            this.searchButton.TabIndex = 50;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            this.CageGridView.Location = new System.Drawing.Point(217, 127);
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
            this.CageGridView.Size = new System.Drawing.Size(620, 465);
            this.CageGridView.TabIndex = 17;
            this.CageGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CageGridView_CellContentDoubleClick);
            this.CageGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CageGridView_RowHeaderMouseClick);
            this.CageGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CageGridView_RowHeaderMouseDoubleClick);
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
            this.panel3.Size = new System.Drawing.Size(218, 584);
            this.panel3.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Create a Cage";
            // 
            // addCage
            // 
            this.addCage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addCage.BackColor = System.Drawing.Color.Transparent;
            this.addCage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addCage.Location = new System.Drawing.Point(21, 500);
            this.addCage.Margin = new System.Windows.Forms.Padding(2);
            this.addCage.Name = "addCage";
            this.addCage.Size = new System.Drawing.Size(170, 57);
            this.addCage.TabIndex = 2;
            this.addCage.Text = "Add Cage";
            this.addCage.UseVisualStyleBackColor = false;
            this.addCage.Click += new System.EventHandler(this.AddCage_Click);
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MaterialComboBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.MaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaterialComboBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(21, 456);
            this.MaterialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(175, 28);
            this.MaterialComboBox.TabIndex = 16;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BirdHouseV2.Properties.Resources.cageIcon;
            this.pictureBox1.Location = new System.Drawing.Point(35, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(21, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Material";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(22, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Height";
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SerialNumberTextBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.SerialNumberTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SerialNumberTextBox.Location = new System.Drawing.Point(22, 179);
            this.SerialNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SerialNumberTextBox.Multiline = true;
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(175, 34);
            this.SerialNumberTextBox.TabIndex = 3;
            this.SerialNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerialNumberTextBox_KeyPress);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeightTextBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.HeightTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.HeightTextBox.Location = new System.Drawing.Point(22, 389);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightTextBox.Multiline = true;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(175, 34);
            this.HeightTextBox.TabIndex = 12;
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Width";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LengthTextBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.LengthTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LengthTextBox.Location = new System.Drawing.Point(21, 248);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LengthTextBox.Multiline = true;
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(175, 34);
            this.LengthTextBox.TabIndex = 4;
            this.LengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LengthTextBox_KeyPress);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WidthTextBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.WidthTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.WidthTextBox.Location = new System.Drawing.Point(22, 317);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthTextBox.Multiline = true;
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(175, 34);
            this.WidthTextBox.TabIndex = 10;
            this.WidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Length";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Serial";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.EditCageButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.OpenCageButton);
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
            this.panel1.Size = new System.Drawing.Size(835, 584);
            this.panel1.TabIndex = 51;
            // 
            // EditCageButton
            // 
            this.EditCageButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditCageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditCageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditCageButton.Location = new System.Drawing.Point(695, 32);
            this.EditCageButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditCageButton.Name = "EditCageButton";
            this.EditCageButton.Size = new System.Drawing.Size(130, 39);
            this.EditCageButton.TabIndex = 53;
            this.EditCageButton.Text = "Edit Cage";
            this.EditCageButton.UseVisualStyleBackColor = true;
            this.EditCageButton.Click += new System.EventHandler(this.EditCageButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(835, 584);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(857, 640);
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
        private System.Windows.Forms.Button OpenCageButton;
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
        private System.Windows.Forms.Button EditCageButton;
    }
}

