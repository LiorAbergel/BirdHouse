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
            this.addCage = new System.Windows.Forms.Button();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.CageGridView = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cageRadioButton = new System.Windows.Forms.RadioButton();
            this.birdRadioButton = new System.Windows.Forms.RadioButton();
            this.subCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.addBirdButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addCage
            // 
            this.addCage.Location = new System.Drawing.Point(33, 404);
            this.addCage.Margin = new System.Windows.Forms.Padding(2);
            this.addCage.Name = "addCage";
            this.addCage.Size = new System.Drawing.Size(121, 82);
            this.addCage.TabIndex = 2;
            this.addCage.Text = "Add Cage";
            this.addCage.UseVisualStyleBackColor = true;
            this.addCage.Click += new System.EventHandler(this.addCage_Click);
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Location = new System.Drawing.Point(33, 56);
            this.SerialNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(121, 29);
            this.SerialNumberTextBox.TabIndex = 3;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(33, 125);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(121, 29);
            this.LengthTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Width";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(33, 202);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(121, 29);
            this.WidthTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Depth";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(37, 262);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(116, 29);
            this.HeightTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Material";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(33, 337);
            this.MaterialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(121, 32);
            this.MaterialComboBox.TabIndex = 16;
            // 
            // CageGridView
            // 
            this.CageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CageGridView.Location = new System.Drawing.Point(183, 56);
            this.CageGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CageGridView.Name = "CageGridView";
            this.CageGridView.RowHeadersWidth = 62;
            this.CageGridView.RowTemplate.Height = 28;
            this.CageGridView.Size = new System.Drawing.Size(911, 314);
            this.CageGridView.TabIndex = 17;
            this.CageGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CageGridView_RowHeaderMouseClick);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(317, 381);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(228, 29);
            this.textBox6.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(190, 385);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 25);
            this.label14.TabIndex = 40;
            this.label14.Text = "Search cage";
            // 
            // cageRadioButton
            // 
            this.cageRadioButton.AutoSize = true;
            this.cageRadioButton.Location = new System.Drawing.Point(999, 378);
            this.cageRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.birdRadioButton.AutoSize = true;
            this.birdRadioButton.Location = new System.Drawing.Point(999, 414);
            this.birdRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.subCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subCategoryComboBox.FormattingEnabled = true;
            this.subCategoryComboBox.Location = new System.Drawing.Point(811, 424);
            this.subCategoryComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subCategoryComboBox.Name = "subCategoryComboBox";
            this.subCategoryComboBox.Size = new System.Drawing.Size(147, 32);
            this.subCategoryComboBox.TabIndex = 45;
            this.subCategoryComboBox.SelectedValueChanged += new System.EventHandler(this.subCategoryComboBox_SelectedValueChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(811, 378);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(147, 32);
            this.categoryComboBox.TabIndex = 46;
            this.categoryComboBox.SelectedValueChanged += new System.EventHandler(this.categoryComboBox_SelectedValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(702, 384);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 47;
            this.label16.Text = "Category";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(675, 433);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 25);
            this.label17.TabIndex = 48;
            this.label17.Text = "Sub Category";
            // 
            // addBirdButton
            // 
            this.addBirdButton.Location = new System.Drawing.Point(33, 490);
            this.addBirdButton.Margin = new System.Windows.Forms.Padding(2);
            this.addBirdButton.Name = "addBirdButton";
            this.addBirdButton.Size = new System.Drawing.Size(121, 80);
            this.addBirdButton.TabIndex = 49;
            this.addBirdButton.Text = "Add Birds";
            this.addBirdButton.UseVisualStyleBackColor = true;
            this.addBirdButton.Click += new System.EventHandler(this.addBirdButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(824, 462);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 45);
            this.searchButton.TabIndex = 50;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 651);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addBirdButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.subCategoryComboBox);
            this.Controls.Add(this.birdRadioButton);
            this.Controls.Add(this.cageRadioButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.CageGridView);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Controls.Add(this.addCage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CageGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addCage;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.DataGridView CageGridView;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton cageRadioButton;
        private System.Windows.Forms.RadioButton birdRadioButton;
        private System.Windows.Forms.ComboBox subCategoryComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button addBirdButton;
        private System.Windows.Forms.Button searchButton;
    }
}

