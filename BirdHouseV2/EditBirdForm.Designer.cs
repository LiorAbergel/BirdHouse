namespace BirdHouseV2
{
    partial class EditBirdForm
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
            this.MotherSerialComboBox = new System.Windows.Forms.ComboBox();
            this.MotherSerialLabel = new System.Windows.Forms.Label();
            this.FatherSerialComboBox = new System.Windows.Forms.ComboBox();
            this.CageSerialComboBox = new System.Windows.Forms.ComboBox();
            this.FatherSerialLabel = new System.Windows.Forms.Label();
            this.CageSerialLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hatchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.specieComboBox = new System.Windows.Forms.ComboBox();
            this.subSpeciesComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MotherSerialComboBox
            // 
            this.MotherSerialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotherSerialComboBox.FormattingEnabled = true;
            this.MotherSerialComboBox.Location = new System.Drawing.Point(136, 553);
            this.MotherSerialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MotherSerialComboBox.Name = "MotherSerialComboBox";
            this.MotherSerialComboBox.Size = new System.Drawing.Size(142, 28);
            this.MotherSerialComboBox.TabIndex = 85;
            // 
            // MotherSerialLabel
            // 
            this.MotherSerialLabel.AutoSize = true;
            this.MotherSerialLabel.Location = new System.Drawing.Point(131, 531);
            this.MotherSerialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MotherSerialLabel.Name = "MotherSerialLabel";
            this.MotherSerialLabel.Size = new System.Drawing.Size(103, 20);
            this.MotherSerialLabel.TabIndex = 84;
            this.MotherSerialLabel.Text = "Mother Serial";
            // 
            // FatherSerialComboBox
            // 
            this.FatherSerialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FatherSerialComboBox.FormattingEnabled = true;
            this.FatherSerialComboBox.Location = new System.Drawing.Point(136, 495);
            this.FatherSerialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FatherSerialComboBox.Name = "FatherSerialComboBox";
            this.FatherSerialComboBox.Size = new System.Drawing.Size(142, 28);
            this.FatherSerialComboBox.TabIndex = 81;
            // 
            // CageSerialComboBox
            // 
            this.CageSerialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CageSerialComboBox.FormattingEnabled = true;
            this.CageSerialComboBox.Location = new System.Drawing.Point(137, 433);
            this.CageSerialComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CageSerialComboBox.Name = "CageSerialComboBox";
            this.CageSerialComboBox.Size = new System.Drawing.Size(142, 28);
            this.CageSerialComboBox.TabIndex = 83;
            this.CageSerialComboBox.SelectedValueChanged += new System.EventHandler(this.CageSerialComboBox_SelectedIndexChanged);
            // 
            // FatherSerialLabel
            // 
            this.FatherSerialLabel.AutoSize = true;
            this.FatherSerialLabel.Location = new System.Drawing.Point(132, 473);
            this.FatherSerialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FatherSerialLabel.Name = "FatherSerialLabel";
            this.FatherSerialLabel.Size = new System.Drawing.Size(100, 20);
            this.FatherSerialLabel.TabIndex = 80;
            this.FatherSerialLabel.Text = "Father Serial";
            // 
            // CageSerialLabel
            // 
            this.CageSerialLabel.AutoSize = true;
            this.CageSerialLabel.Location = new System.Drawing.Point(132, 411);
            this.CageSerialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CageSerialLabel.Name = "CageSerialLabel";
            this.CageSerialLabel.Size = new System.Drawing.Size(91, 20);
            this.CageSerialLabel.TabIndex = 82;
            this.CageSerialLabel.Text = "Cage Serial";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(137, 368);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(142, 28);
            this.genderComboBox.TabIndex = 79;
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(137, 133);
            this.serialTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(142, 26);
            this.serialTextBox.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 71;
            this.label9.Text = "Specie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "Hatch date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Gender";
            // 
            // hatchDateTimePicker
            // 
            this.hatchDateTimePicker.Location = new System.Drawing.Point(134, 310);
            this.hatchDateTimePicker.Name = "hatchDateTimePicker";
            this.hatchDateTimePicker.Size = new System.Drawing.Size(144, 26);
            this.hatchDateTimePicker.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 74;
            this.label10.Text = "Serial";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 234);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 77;
            this.label11.Text = "Sub Specie";
            // 
            // specieComboBox
            // 
            this.specieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specieComboBox.FormattingEnabled = true;
            this.specieComboBox.Location = new System.Drawing.Point(137, 193);
            this.specieComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.specieComboBox.Name = "specieComboBox";
            this.specieComboBox.Size = new System.Drawing.Size(142, 28);
            this.specieComboBox.TabIndex = 75;
            this.specieComboBox.SelectedValueChanged += new System.EventHandler(this.specieComboBox_SelectedIndexChanged);
            // 
            // subSpeciesComboBox
            // 
            this.subSpeciesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subSpeciesComboBox.FormattingEnabled = true;
            this.subSpeciesComboBox.Location = new System.Drawing.Point(137, 259);
            this.subSpeciesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.subSpeciesComboBox.Name = "subSpeciesComboBox";
            this.subSpeciesComboBox.Size = new System.Drawing.Size(142, 28);
            this.subSpeciesComboBox.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 31);
            this.label6.TabIndex = 86;
            this.label6.Text = "Edit Bird";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ConfirmButton.Location = new System.Drawing.Point(121, 602);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(170, 57);
            this.ConfirmButton.TabIndex = 87;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // EditBirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 711);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MotherSerialComboBox);
            this.Controls.Add(this.MotherSerialLabel);
            this.Controls.Add(this.FatherSerialComboBox);
            this.Controls.Add(this.CageSerialComboBox);
            this.Controls.Add(this.FatherSerialLabel);
            this.Controls.Add(this.CageSerialLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.serialTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hatchDateTimePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.specieComboBox);
            this.Controls.Add(this.subSpeciesComboBox);
            this.Name = "EditBirdForm";
            this.Text = "EditBirdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MotherSerialComboBox;
        private System.Windows.Forms.Label MotherSerialLabel;
        private System.Windows.Forms.ComboBox FatherSerialComboBox;
        private System.Windows.Forms.ComboBox CageSerialComboBox;
        private System.Windows.Forms.Label FatherSerialLabel;
        private System.Windows.Forms.Label CageSerialLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker hatchDateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox specieComboBox;
        private System.Windows.Forms.ComboBox subSpeciesComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ConfirmButton;
    }
}