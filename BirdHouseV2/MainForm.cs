using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DemoLibrary.Cage;

namespace BirdHouseV2
{
    public partial class MainForm : Form
    {
        List<Cage> Cages = new List<Cage>();
        string ownerID;
        string cageSerial;

        public MainForm(string id)
        {
            InitializeComponent();

            ownerID = id;
            
            LoadCageList();
        }

        private void LoadCageList()
        {
            // TODO - Get real data hear
            Cages = SqliteDataAccess.LoadCages(ownerID);
            WireUpCagesList();
        }

        private void WireUpCagesList()
        {
            CageGridView.DataSource = Cages;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            var MaterialString = Enum.GetNames(typeof(Material));
            MaterialComboBox.Items.AddRange(MaterialString);

             
        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
        }

        private void addCage_Click(object sender, EventArgs e)
        {
            string serial = SerialNumberTextBox.Text;
            string material = MaterialComboBox.SelectedItem as string;
            if (material == null)
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
                        MessageBox.Show("Invalide Legnth! \njust numbers and letters allowed!");
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
                        MessageBox.Show("Invalide Width! \njust numbers allowed!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter Widgth!");
                return;
            }
            string height = HeightTextBox.Text;
            if (height.Length > 0)
            {
                foreach (char c in height)
                {

                    if (!(char.IsNumber(c)))
                    {
                        MessageBox.Show("Invalide Height! \njust numbers allowed!");
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

            SqliteDataAccess.saveCage(cage_test);

            LoadCageList();
        }

        private void listCagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cageRadioButton_Click(object sender, EventArgs e)
        {
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.AddRange(new string[] { "Serial", "Material" });
        }

        private void birdRadioButton_Click(object sender, EventArgs e)
        {
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.AddRange(new string[] { "Serial", "Species", "Hatch Date", "Gender" });
        }

        private void categoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cageRadioButton.Checked)
            {
                if (categoryComboBox.SelectedItem.ToString() == "Material")
                {
                    subCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    subCategoryComboBox.Items.AddRange(Enum.GetNames(typeof(Material)));
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

        private void subCategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void addBirdButton_Click(object sender, EventArgs e)
        {
            var birdsForm = new BirdsForm(cageSerial);
            birdsForm.ShowDialog();
        }

        private void CageGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cageSerial = CageGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (cageRadioButton.Checked)
            {
                string catagory = categoryComboBox.SelectedItem as string;
                if (catagory == "Material")
                {
                    string subCatagory = subCategoryComboBox.SelectedItem as string;
                    Cages = SqliteDataAccess.searchCages(subCatagory, catagory);
                }
                if (catagory == "Serial")
                {
                    string Serial = subCategoryComboBox.Text;
                    Cages = SqliteDataAccess.searchCages(Serial, catagory);
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
                    Cages = SqliteDataAccess.searchCages(subCatagory, catagory);
                }
                if (catagory == "Serial")
                {
                    string Serial = subCategoryComboBox.Text;
                    birds = SqliteDataAccess.searchBirds(Serial, catagory);
                }
                if (catagory == "Hatch Date")
                {
                    string subCatagory = subCategoryComboBox.SelectedItem as string;
                    Cages = SqliteDataAccess.searchCages(subCatagory, catagory);
                }

                if (catagory == "Gender")
                {
                    string subCatagory = subCategoryComboBox.SelectedItem as string;
                    Cages = SqliteDataAccess.searchCages(subCatagory, catagory);
                }


                CageGridView.DataSource = birds;
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
