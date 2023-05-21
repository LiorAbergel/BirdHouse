using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

namespace BirdHouse
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

            if (userName.Length < 6 || userName.Length > 8)
            {
                MessageBox.Show("Invalide username length! \n need to be between 6 to 8 digits!");
                return;
            }

            // Check if the username contains at most 2 digitss
            int digitCount = Regex.Matches(userName, @"\d").Count;
            if (Regex.Matches(userName, @"\d").Count > 2)
            {
                MessageBox.Show("Invalide username ! \n it can only contain 2 digits ");
                return;
            }

            // Check if the username contains only letters and digits
            if (!Regex.IsMatch(userName, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Invalide username ! \n it can only contain letters and digits ");
                return;
            }

            if (password.Length >= 8 && password.Length <= 10)
            {
                bool specialFlag = false;
                bool numberFlag = false;
                bool charFlag = false;
                foreach (char c in password)
                {

                    if (char.IsSymbol(c) || char.IsPunctuation(c))
                        specialFlag = true;

                    if (char.IsNumber(c))
                        numberFlag = true;

                    if (char.IsLetter(c))
                        charFlag = true;

                }
                if (specialFlag == false)
                {
                    MessageBox.Show("Invalid password! \n need to contain at least 1 special character!");
                    return;
                }
                if (numberFlag == false)
                {
                    MessageBox.Show("Invalid password! \n need to contain at least 1 number!");
                    return;
                }
                if (charFlag == false)
                {
                    MessageBox.Show("Invalid password! \n need to contain at least 1 letter!");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Invalid password length! \n need to be between 8 to 10 digits!");
                return;
            }

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
                MessageBox.Show("Invalid ID length! should be 7 to 8 digits");
                return;
            }

            // if input check passed , we can save the data to the file 
            using (var usersFile = new ExcelPackage(new FileInfo(usersFilePath)))
            {
                // Get the first worksheet
                ExcelWorksheet worksheet = usersFile.Workbook.Worksheets[0];

                int rowCount = worksheet.Dimension.Rows;
                for (int row = 2; row <= rowCount + 1; row++)
                {
                    if (worksheet.Cells[row, 1].Value == null)
                    {
                        worksheet.Cells[row, 1].Value = id;
                        worksheet.Cells[row, 2].Value = userName;
                        worksheet.Cells[row, 3].Value = password;
                        usersFile.Save();
                        MessageBox.Show("Register Successful !");
                        Close();
                    }
                }
            }
        }
    
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // this line adds an event handler to detect this form closing
            this.FormClosing += new FormClosingEventHandler(this.RegisterForm_FormClosing);
        }

        private void RegisterForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // this method is activated when the form is closed , it closes the excel file
        }

    }
}
