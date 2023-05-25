using System.Drawing;
using System.Windows.Forms;

namespace BirdHouseV2
{
    partial class RegisterForm
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
            label2 = new Label();
            label1 = new Label();
            userNameBox = new TextBox();
            passwordBox = new TextBox();
            label3 = new Label();
            idBox = new TextBox();
            label4 = new Label();
            confirmButton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 105);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 8;
            label2.Text = "Password : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 68);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 7;
            label1.Text = "User Name :";
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(121, 62);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(235, 31);
            userNameBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(121, 100);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(235, 31);
            passwordBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 145);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 10;
            label3.Text = "ID : ";
            // 
            // idBox
            // 
            idBox.Location = new Point(121, 140);
            idBox.Name = "idBox";
            idBox.Size = new Size(235, 31);
            idBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 23);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 11;
            label4.Text = "Register";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(121, 177);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(111, 33);
            confirmButton.TabIndex = 12;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(246, 177);
            button2.Name = "button2";
            button2.Size = new Size(111, 33);
            button2.TabIndex = 13;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 240);
            Controls.Add(button2);
            Controls.Add(confirmButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(idBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userNameBox);
            Controls.Add(passwordBox);
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox userNameBox;
        private TextBox passwordBox;
        private Label label3;
        private TextBox idBox;
        private Label label4;
        private Button confirmButton;
        private Button button2;
    }
}