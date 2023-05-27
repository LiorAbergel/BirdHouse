namespace BirdHouseV2
{
    partial class BirdsViewForm
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
            this.hatchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.subSpeciesComboBox = new System.Windows.Forms.ComboBox();
            this.specieComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.addBirdButton = new System.Windows.Forms.Button();
            this.BirdGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MotherSerialComboBox = new System.Windows.Forms.ComboBox();
            this.MotherSerialLabel = new System.Windows.Forms.Label();
            this.FatherSerialComboBox = new System.Windows.Forms.ComboBox();
            this.CageSerialComboBox = new System.Windows.Forms.ComboBox();
            this.FatherSerialLabel = new System.Windows.Forms.Label();
            this.CageSerialLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddChildToBirdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BirdGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hatchDateTimePicker
            // 
            this.hatchDateTimePicker.Location = new System.Drawing.Point(10, 206);
            this.hatchDateTimePicker.Name = "hatchDateTimePicker";
            this.hatchDateTimePicker.Size = new System.Drawing.Size(144, 26);
            this.hatchDateTimePicker.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 53;
            this.label11.Text = "Sub Specie";
            // 
            // subSpeciesComboBox
            // 
            this.subSpeciesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subSpeciesComboBox.FormattingEnabled = true;
            this.subSpeciesComboBox.Location = new System.Drawing.Point(10, 155);
            this.subSpeciesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.subSpeciesComboBox.Name = "subSpeciesComboBox";
            this.subSpeciesComboBox.Size = new System.Drawing.Size(142, 28);
            this.subSpeciesComboBox.TabIndex = 52;
            this.subSpeciesComboBox.SelectedValueChanged += new System.EventHandler(this.SubSpeciesComboBox_SelectedValueChanged);
            // 
            // specieComboBox
            // 
            this.specieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specieComboBox.FormattingEnabled = true;
            this.specieComboBox.Location = new System.Drawing.Point(10, 89);
            this.specieComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.specieComboBox.Name = "specieComboBox";
            this.specieComboBox.Size = new System.Drawing.Size(142, 28);
            this.specieComboBox.TabIndex = 51;
            this.specieComboBox.SelectedValueChanged += new System.EventHandler(this.SpecieComboBox_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Serial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Hatch date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Specie";
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(10, 29);
            this.serialTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(142, 26);
            this.serialTextBox.TabIndex = 44;
            this.serialTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerialTextBox_KeyPress);
            // 
            // addBirdButton
            // 
            this.addBirdButton.Location = new System.Drawing.Point(10, 519);
            this.addBirdButton.Name = "addBirdButton";
            this.addBirdButton.Size = new System.Drawing.Size(145, 57);
            this.addBirdButton.TabIndex = 62;
            this.addBirdButton.Text = "Add Bird";
            this.addBirdButton.UseVisualStyleBackColor = true;
            this.addBirdButton.Click += new System.EventHandler(this.AddBirdButton_Click);
            // 
            // BirdGridView
            // 
            this.BirdGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BirdGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BirdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.142858F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BirdGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.BirdGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BirdGridView.Location = new System.Drawing.Point(0, 0);
            this.BirdGridView.MultiSelect = false;
            this.BirdGridView.Name = "BirdGridView";
            this.BirdGridView.RowHeadersWidth = 62;
            this.BirdGridView.Size = new System.Drawing.Size(762, 547);
            this.BirdGridView.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BirdGridView);
            this.panel1.Location = new System.Drawing.Point(148, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 547);
            this.panel1.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BirdHouseV2.Properties.Resources.background_1;
            this.panel2.Controls.Add(this.MotherSerialComboBox);
            this.panel2.Controls.Add(this.MotherSerialLabel);
            this.panel2.Controls.Add(this.FatherSerialComboBox);
            this.panel2.Controls.Add(this.CageSerialComboBox);
            this.panel2.Controls.Add(this.FatherSerialLabel);
            this.panel2.Controls.Add(this.CageSerialLabel);
            this.panel2.Controls.Add(this.genderComboBox);
            this.panel2.Controls.Add(this.addBirdButton);
            this.panel2.Controls.Add(this.serialTextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.hatchDateTimePicker);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.specieComboBox);
            this.panel2.Controls.Add(this.subSpeciesComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 603);
            this.panel2.TabIndex = 0;
            // 
            // MotherSerialComboBox
            // 
            this.MotherSerialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotherSerialComboBox.FormattingEnabled = true;
            this.MotherSerialComboBox.Location = new System.Drawing.Point(9, 449);
            this.MotherSerialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MotherSerialComboBox.Name = "MotherSerialComboBox";
            this.MotherSerialComboBox.Size = new System.Drawing.Size(142, 28);
            this.MotherSerialComboBox.TabIndex = 69;
            // 
            // MotherSerialLabel
            // 
            this.MotherSerialLabel.AutoSize = true;
            this.MotherSerialLabel.Location = new System.Drawing.Point(4, 427);
            this.MotherSerialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MotherSerialLabel.Name = "MotherSerialLabel";
            this.MotherSerialLabel.Size = new System.Drawing.Size(103, 20);
            this.MotherSerialLabel.TabIndex = 68;
            this.MotherSerialLabel.Text = "Mother Serial";
            // 
            // FatherSerialComboBox
            // 
            this.FatherSerialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FatherSerialComboBox.FormattingEnabled = true;
            this.FatherSerialComboBox.Location = new System.Drawing.Point(9, 391);
            this.FatherSerialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FatherSerialComboBox.Name = "FatherSerialComboBox";
            this.FatherSerialComboBox.Size = new System.Drawing.Size(142, 28);
            this.FatherSerialComboBox.TabIndex = 66;
            // 
            // CageSerialComboBox
            // 
            this.CageSerialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CageSerialComboBox.FormattingEnabled = true;
            this.CageSerialComboBox.Location = new System.Drawing.Point(10, 329);
            this.CageSerialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CageSerialComboBox.Name = "CageSerialComboBox";
            this.CageSerialComboBox.Size = new System.Drawing.Size(142, 28);
            this.CageSerialComboBox.TabIndex = 67;
            this.CageSerialComboBox.SelectedValueChanged += new System.EventHandler(this.CageSerialComboBox_SelectedValueChanged);
            // 
            // FatherSerialLabel
            // 
            this.FatherSerialLabel.AutoSize = true;
            this.FatherSerialLabel.Location = new System.Drawing.Point(5, 369);
            this.FatherSerialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FatherSerialLabel.Name = "FatherSerialLabel";
            this.FatherSerialLabel.Size = new System.Drawing.Size(100, 20);
            this.FatherSerialLabel.TabIndex = 65;
            this.FatherSerialLabel.Text = "Father Serial";
            // 
            // CageSerialLabel
            // 
            this.CageSerialLabel.AutoSize = true;
            this.CageSerialLabel.Location = new System.Drawing.Point(5, 307);
            this.CageSerialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CageSerialLabel.Name = "CageSerialLabel";
            this.CageSerialLabel.Size = new System.Drawing.Size(91, 20);
            this.CageSerialLabel.TabIndex = 66;
            this.CageSerialLabel.Text = "Cage Serial";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(10, 264);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(142, 28);
            this.genderComboBox.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 64;
            this.label1.Text = "Bird View";
            // 
            // AddChildToBirdButton
            // 
            this.AddChildToBirdButton.Location = new System.Drawing.Point(735, 22);
            this.AddChildToBirdButton.Name = "AddChildToBirdButton";
            this.AddChildToBirdButton.Size = new System.Drawing.Size(145, 57);
            this.AddChildToBirdButton.TabIndex = 63;
            this.AddChildToBirdButton.Text = "Add Child To Bird";
            this.AddChildToBirdButton.UseVisualStyleBackColor = true;
            this.AddChildToBirdButton.Click += new System.EventHandler(this.AddChildToBirdButton_Click);
            // 
            // BirdsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::BirdHouseV2.Properties.Resources.background_2;
            this.ClientSize = new System.Drawing.Size(892, 603);
            this.Controls.Add(this.AddChildToBirdButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BirdsViewForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bird View";
            this.Load += new System.EventHandler(this.BirdsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BirdGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker hatchDateTimePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox subSpeciesComboBox;
        private System.Windows.Forms.ComboBox specieComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.Button addBirdButton;
        private System.Windows.Forms.DataGridView BirdGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button AddChildToBirdButton;
        private System.Windows.Forms.ComboBox CageSerialComboBox;
        private System.Windows.Forms.Label CageSerialLabel;
        private System.Windows.Forms.ComboBox FatherSerialComboBox;
        private System.Windows.Forms.Label FatherSerialLabel;
        private System.Windows.Forms.ComboBox MotherSerialComboBox;
        private System.Windows.Forms.Label MotherSerialLabel;
    }
}