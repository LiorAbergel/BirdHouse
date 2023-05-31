using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DemoLibrary.Cage;
using static DemoLibrary.Bird;
using System.Linq;
using System.ComponentModel;

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

            Cage cageToSave = new Cage(ownerID, serial, length, width, height , material);
            SqliteDataAccess.SaveCage(cageToSave);

            MessageBox.Show("Cage added successfully !");

            LoadCageList();
        }

        private void CageRadioButton_Click(object sender, EventArgs e)
        {
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.AddRange(new string[] { "Serial", "Material" });

            subCategoryComboBox.Text = "";
            subCategoryComboBox.Items.Clear();
        }

        private void BirdRadioButton_Click(object sender, EventArgs e)
        {
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.AddRange(new string[] { "Serial", "Specie", "Hatch Date", "Gender" });

            subCategoryComboBox.Text = "";
            subCategoryComboBox.Items.Clear();
        }

        private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            subCategoryComboBox.Text = "";

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
                    subCategoryComboBox.Text = "Please enter a cage serial";
                }
            }

            else if (birdRadioButton.Checked)
            {
                var input = categoryComboBox.SelectedItem.ToString();
                switch (input)
                {
                    case "Serial":
                        subCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                        subCategoryComboBox.Text = "Please enter a bird serial";
                        // TODO : birds serial can only contain digits !
                        break;

                    case "Specie":
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

        private void OpenCageButton_Click(object sender, EventArgs e)
        {
            // first check if a cage was selected , if not , show a message to user 
            if (CageGridView.SelectedRows.Count > 0)
            {
                var birdsForm = new BirdsViewForm(ownerID, cageSerial);
                birdsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a cage to open !");
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
                string category = categoryComboBox.SelectedItem as string;

                if (category == "Material")
                {
                    string materialType = subCategoryComboBox.SelectedItem as string;

                    if (materialType == null)
                    {
                        MessageBox.Show("Please select type of material !");
                        return;
                    }

                    else Cages = SqliteDataAccess.SearchCages(ownerID, materialType, category);
                }

                else if (category == "Serial")
                {
                    string serial = subCategoryComboBox.Text;

                    if (serial == null || serial == "Please enter a cage serial")
                    {
                        MessageBox.Show("Please enter cage serial !");
                        return;
                    }

                    else Cages = SqliteDataAccess.SearchCages(ownerID, serial, category);
                }

                else
                {
                    MessageBox.Show("Please select a category !");
                    return;
                }

                WireUpCagesList();
            }

            else if (birdRadioButton.Checked)
            {
                List<Bird> birds= new List<Bird>();

                string category = categoryComboBox.SelectedItem as string;

                if (category == "Specie")
                {
                    string specie = subCategoryComboBox.SelectedItem as string;
                    birds = SqliteDataAccess.SearchBirds(specie, category);
                }

                else if (category == "Serial")
                {
                    string serial = subCategoryComboBox.Text;
                    birds = SqliteDataAccess.SearchBirds(serial, category);
                }

                else if (category == "Hatch Date")
                {
                    //TODO : complete search by date
                    string hatchDate = subCategoryComboBox.SelectedItem as string;
                    birds = SqliteDataAccess.SearchBirds(hatchDate, category);
                }

                else if (category == "Gender")
                {
                    string gender = subCategoryComboBox.SelectedItem as string;
                    birds = SqliteDataAccess.SearchBirds(gender, category);
                }

                if (birds != null)
                {
                    var birdsForm = new BirdsViewForm(ownerID, birds);
                    birdsForm.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Please select a category !");
                    return;
                }

            }

            else
            {
                MessageBox.Show("Please select items to search ! (Cage / Birds) ");
                return;
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

        private void EditCageButton_Click(object sender, EventArgs e)
        {
            var editCageForm = new EditCageForm(cageSerial);
            editCageForm.ShowDialog();

            LoadCageList();
        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
