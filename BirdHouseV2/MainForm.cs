using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DemoLibrary.Cage;
using static DemoLibrary.Bird;


namespace BirdHouseV2
{
    public partial class MainForm : Form
    {
        List<Cage> Cages = new List<Cage>();
        readonly string ownerID;
        string cageSerial;

        public MainForm(string ownerID)
        {
            InitializeComponent();

            this.ownerID = ownerID;
            LoadCageList();
        }

        private void LoadCageList()
        {
            Cages = SqliteDataAccess.LoadCages(ownerID);
            WireUpCagesList();
        }

        private void WireUpCagesList()
        {
            CageGridView.DataSource = Cages;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            var MaterialString = Enum.GetNames(typeof(Materials));
            MaterialComboBox.Items.AddRange(MaterialString);
        }

        private void AddCage_Click(object sender, EventArgs e)
        {
            string serial = SerialNumberTextBox.Text;
            if (!(MaterialComboBox.SelectedItem is string material))
            {
                MessageBox.Show("Enter Material!");
                return;
            }

            string length = LengthTextBox.Text;
            if (length.Length > 0)
            {
                foreach (char c in length)
                {

                    if (!(char.IsNumber(c) || char.IsLetter(c)))
                    {
                        MessageBox.Show("Invalid Legnth! \njust numbers and letters allowed!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Length!");
                return;
            }
            string width = WidthTextBox.Text;
            if (width.Length > 0)
            {
                foreach (char c in width)
                {

                    if (!(char.IsNumber(c)))
                    {
                        MessageBox.Show("Invalid Width! \n only numbers allowed!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter Width!");
                return;
            }
            string height = HeightTextBox.Text;
            if (height.Length > 0)
            {
                foreach (char c in height)
                {

                    if (!(char.IsNumber(c)))
                    {
                        MessageBox.Show("Invalid Height! \njust numbers allowed!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter Height!");
                return;
            }

            Cage cage_test = new Cage(ownerID, serial, length, width, height , material);

            SqliteDataAccess.SaveCage(cage_test);

            LoadCageList();
        }

        private void CageRadioButton_Click(object sender, EventArgs e)
        {
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.AddRange(new string[] { "Serial", "Material" });
        }

        private void BirdRadioButton_Click(object sender, EventArgs e)
        {
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.AddRange(new string[] { "Serial", "Species", "Hatch Date", "Gender" });
        }

        private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cageRadioButton.Checked)
            {
                if (categoryComboBox.SelectedItem.ToString() == "Material")
                {
                    subCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    subCategoryComboBox.Items.AddRange(Enum.GetNames(typeof(Materials)));
                }
                else
                {
                    subCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                }
            }

            else if (birdRadioButton.Checked)
            {
                var input = categoryComboBox.SelectedItem.ToString();
                switch (input)
                {
                    case "Serial":
                        subCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                        break;

                    case "Species":
                        subCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        subCategoryComboBox.Items.Clear();
                        subCategoryComboBox.Items.AddRange(Enum.GetNames(typeof(Species)));
                        break;

                    case "Hatch Date":
                        subCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        subCategoryComboBox.Items.Clear();
                        // TODO : get all hatch dates of user's birds from db
                        break;

                    case "Gender":
                        subCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                        subCategoryComboBox.Items.Clear();
                        subCategoryComboBox.Items.AddRange(new string[] { "Male", "Female" });
                        break;

                    default:
                        subCategoryComboBox.Items.Clear();
                        break;
                }
            }

        }

        private void AddBirdButton_Click(object sender, EventArgs e)
        {
            // first check if a cage was selected , if not , show a message to user 
            if (CageGridView.SelectedRows.Count > 0)
            {
                var birdsForm = new BirdsForm(cageSerial);
                birdsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a cage to add birds !");
                return;
            }
        }

        private void CageGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cageSerial = CageGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (cageRadioButton.Checked)
            {
                string catagory = categoryComboBox.SelectedItem as string;
                if (catagory == "Material")
                {
                    string subCatagory = subCategoryComboBox.SelectedItem as string;
                    Cages = SqliteDataAccess.SearchCages(subCatagory, catagory);
                }
                if (catagory == "Serial")
                {
                    string Serial = subCategoryComboBox.Text;
                    Cages = SqliteDataAccess.SearchCages(Serial, catagory);
                }
                CageGridView.DataSource = Cages;
            }

            if (birdRadioButton.Checked)
            {
                List<Bird> birds= new List<Bird>();
                string catagory = categoryComboBox.SelectedItem as string;
                if (catagory == "Species")
                {
                    string subCatagory = subCategoryComboBox.SelectedItem as string;
                    Cages = SqliteDataAccess.SearchCages(subCatagory, catagory);
                }
                if (catagory == "Serial")
                {
                    string Serial = subCategoryComboBox.Text;
                    birds = SqliteDataAccess.SearchBirds(Serial, catagory);
                }
                if (catagory == "Hatch Date")
                {
                    string subCatagory = subCategoryComboBox.SelectedItem as string;
                    Cages = SqliteDataAccess.SearchCages(subCatagory, catagory);
                }

                if (catagory == "Gender")
                {
                    string subCatagory = subCategoryComboBox.SelectedItem as string;
                    Cages = SqliteDataAccess.SearchCages(subCatagory, catagory);
                }

                CageGridView.DataSource = birds;
            }


        }

        private void SerialNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit, a letter, or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the keypress event
            }
        }

        private void LengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the keypress event
            }
        }

        private void WidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the keypress event
            }
        }

        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the keypress event
            }
        }
    }
}
