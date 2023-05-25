using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;


namespace BirdHouseV2
{
    public partial class LogInForm : Form
    {
        string usersFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\users.xls";
        public LogInForm()
        {
            InitializeComponent();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

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

                ExcelRangeBase range = worksheet.Cells[2, 1, endCell.Row, endCell.Column];

                // TODO : add input checking
                string userName = userNameBox.Text;
                string password = passwordBox.Text;
                string id = null;

                bool foundUser = false;

                foreach (ExcelRangeBase cell in range)
                {
                    if (cell.Value != null && cell.Value.ToString() == userName)
                    {
                        ExcelRange passwordCell = worksheet.Cells[cell.Start.Row, cell.Start.Column + 1]; // Get the corresponding password cell
                        if (passwordCell.Value != null && passwordCell.Value.ToString() == password)
                        {
                            // Username and password found
                            foundUser = true;
                            id = worksheet.Cells[cell.Start.Row, cell.Start.Column].Value.ToString();
                            break;
                        }
                    }
                }

                if (foundUser && id != null)
                {
                    MainForm mainForm = new MainForm(id);
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password !");
                    return;
                }

            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            // this line adds an event handler to detect this form closing
            FormClosing += new FormClosingEventHandler(LogInForm_FormClosing);
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LogInButton_Click_1(object sender, EventArgs e)
        {

        }

        private void LogInForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

