namespace BirdHouse
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
            LogInButton = new Button();
            passwordBox = new TextBox();
            userNameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            registerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(314, 282);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(112, 35);
            LogInButton.TabIndex = 0;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(314, 245);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(236, 31);
            passwordBox.TabIndex = 1;
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(314, 209);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(236, 31);
            userNameBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 214);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 3;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 251);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 4;
            label2.Text = "Password : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(175, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 173);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(432, 282);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(112, 35);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 334);
            Controls.Add(registerButton);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userNameBox);
            Controls.Add(passwordBox);
            Controls.Add(LogInButton);
            Name = "LogInForm";
            Text = "Log In";
            Load += LogInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogInButton;
        private TextBox passwordBox;
        private TextBox userNameBox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button registerButton;
    }
}