using OfficeOpenXml;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BirdHouseV2
{
    public partial class RegisterForm : Form
    {
        string usersFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\users.xls";
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string userName = userNameBox.Text;
            string password = passwordBox.Text;
            string id = idBox.Text;

            // checks username length
            if (userName.Length < 6 || userName.Length > 8)
            {
                MessageBox.Show("Invalid username length! \n needs to be 6 - 8 characters long !");
                return;
            }

            // Check if the username contains at most 2 digitss
            int digitCount = Regex.Matches(userName, @"\d").Count;
            if (digitCount > 2)
            {
                MessageBox.Show("Invalid username ! \n it can only contain 2 digits ");
                return;
            }

            // Check if the username contains only letters and digits
            if (!Regex.IsMatch(userName, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Invalid username ! \n it can only contain letters and digits");
                return;
            }

            // Before checking password content , check if length is valid
            if (password.Length >= 8 && password.Length <= 10)
            {
                bool specialFlag = false;
                bool numberFlag = false;
                bool charFlag = false;
                foreach (char c in password)
                {
                    if (specialFlag && numberFlag && charFlag) break;
                    else if (char.IsSymbol(c) || char.IsPunctuation(c)) specialFlag = true;
                    else if (char.IsNumber(c)) numberFlag = true;
                    else if (char.IsLetter(c)) charFlag = true;
                }

                if (!specialFlag)
                {
                    MessageBox.Show("Invalid password! \n needs to contain at least 1 special character!");
                    return;
                }
                if (!numberFlag)
                {
                    MessageBox.Show("Invalid password! \n needs to contain at least 1 number!");
                    return;
                }
                if (!charFlag)
                {
                    MessageBox.Show("Invalid password! \n needs to contain at least 1 letter!");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Invalid password length! \n needs to be 8 - 10 characters long!");
                return;
            }

            // Before checking ID content , check if length is valid
            if (id.Length >= 7 && id.Length <= 9)
            {
                foreach (char c in id)
                {
                    if (!(char.IsNumber(c)))
                    {
                        MessageBox.Show("Invalid ID! \n only digits allowed!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid ID length! should be 7 - 8 digits long !");
                return;
            }

            // if input check passed , we can save the data to the file 
            using (var usersFile = new ExcelPackage(new FileInfo(usersFilePath)))
            {
                // Get the first worksheet
                ExcelWorksheet worksheet = usersFile.Workbook.Worksheets[0];

                bool IDExists = false;
                bool userNameExists = false;
                int rowCount = worksheet.Dimension.Rows;
                for (int row = 2; row <= rowCount + 1; row++)
                {
                    if (worksheet.Cells[row, 1].Value == null)
                    {
                        if (!IDExists && !userNameExists)
                        {
                            worksheet.Cells[row, 1].Value = id;
                            worksheet.Cells[row, 2].Value = userName;
                            worksheet.Cells[row, 3].Value = password;

                            usersFile.Save();
                            MessageBox.Show("Register Successful !");
                            Close();
                        }

                        else if (IDExists)
                        {
                            MessageBox.Show("ID already registered !");
                            return;
                        }

                        else if (userNameExists)
                        {
                            MessageBox.Show("Username already registered !");
                            return;
                        }
                    
                    }
                    else
                    {
                        if (worksheet.Cells[row, 1].Value.ToString() == id) IDExists = true;
                        if (worksheet.Cells[row, 2].Value.ToString() == userName) userNameExists = true;
                    }
                }
            }
        }

        private void idBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the keypress event
            }
        }
    }
}
