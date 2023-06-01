using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;


namespace BirdHouseV2
{
    public partial class LogInForm : Form
    {
        readonly string usersFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\users.xls";
        public LogInForm()
        {
            InitializeComponent();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // checks if a users file exist , if not , creates one
            if (!File.Exists(usersFilePath))
            {
                // Create a new Excel package
                using (var usersFile = new ExcelPackage())
                {
                    // Add a new worksheet to the package
                    ExcelWorksheet worksheet = usersFile.Workbook.Worksheets.Add("Users");

                    // Customize the worksheet as needed
                    worksheet.Cells["A1"].Value = "id";
                    worksheet.Cells["B1"].Value = "username";
                    worksheet.Cells["C1"].Value = "password";

                    // Save the package to the specified file path
                    usersFile.SaveAs(new FileInfo(usersFilePath));
                }
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            // finding the path to the data file
            using (var usersFile = new ExcelPackage(new FileInfo(usersFilePath)))
            {
                // Get the first worksheet
                ExcelWorksheet worksheet = usersFile.Workbook.Worksheets[0];

                // Get the dimension of the worksheet (the range of cells containing data)
                ExcelCellAddress endCell = worksheet.Dimension.End;

                // Initioalize range of search
                ExcelRangeBase range = worksheet.Cells[2, 1, endCell.Row, endCell.Column];

                string userName = userNameBox.Text;
                string password = passwordBox.Text;

                if (userName == "")
                {
                    MessageBox.Show("Please enter username !");
                    return;
                }

                else if (password == "")
                {
                    MessageBox.Show("Please enter password !");
                    return;
                }

                string id = null;
                bool foundUserName = false;
                bool foundPassword = false;

                foreach (ExcelRangeBase cell in range)
                {
                    if (cell.Value != null && cell.Value.ToString() == userName)
                    {
                        // Username found
                        foundUserName = true;
                        ExcelRange passwordCell = worksheet.Cells[cell.Start.Row, cell.Start.Column + 1]; // Get the corresponding password cell
                        if (passwordCell.Value != null && passwordCell.Value.ToString() == password)
                        {
                            // Password found
                            foundPassword = true;
                            id = worksheet.Cells[cell.Start.Row, cell.Start.Column].Value.ToString(); // Get the corresponding id cell
                            break;
                        }
                    }

                }

                if (foundUserName && foundPassword)
                {
                    if (id != null)
                    {
                        MainForm mainForm = new MainForm(id);
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Unable to get some of the data from the database , \n please contact administration !");
                        return;
                    }
                }

                else if (!foundUserName)
                {
                    MessageBox.Show("Incorrect username!");
                    return;
                }

                else if (!foundPassword)
                {
                    MessageBox.Show("Incorrect password!");
                    return;
                }

                else
                {
                    MessageBox.Show("Incorrect username and password!");
                    return;
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void userNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit, a letter, or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the keypress event
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

