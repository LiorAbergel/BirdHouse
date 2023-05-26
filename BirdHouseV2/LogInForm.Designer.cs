using System.Drawing;
using System.Windows.Forms;

namespace BirdHouseV2
{
    partial class LogInForm
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
            this.LogInButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogInButton.BackColor = System.Drawing.Color.White;
            this.LogInButton.Location = new System.Drawing.Point(47, 367);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(155, 70);
            this.LogInButton.TabIndex = 0;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.BackColor = System.Drawing.Color.MistyRose;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(138, 287);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(259, 45);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // userNameBox
            // 
            this.userNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameBox.BackColor = System.Drawing.Color.Cornsilk;
            this.userNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameBox.Location = new System.Drawing.Point(138, 204);
            this.userNameBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.userNameBox.Multiline = true;
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(259, 45);
            this.userNameBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password : ";
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.Location = new System.Drawing.Point(226, 367);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(155, 70);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.LogInButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userNameBox);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 549);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BirdHouseV2.Properties.Resources.SCE_logo;
            this.pictureBox2.Location = new System.Drawing.Point(25, -35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(394, 318);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 549);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogInForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button LogInButton;
        private TextBox passwordBox;
        private TextBox userNameBox;
        private Label label1;
        private Label label2;
        private Button registerButton;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}