using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DemoLibrary.Bird;

namespace BirdHouseV2
{
    public partial class BirdsForm : Form
    {
        public string CageSerial { get; set; }

        List<Bird> Birds;

        public BirdsForm(string cageSerial)
        {
            InitializeComponent();

            Birds = new List<Bird>();
            CageSerial = cageSerial;
            specieComboBox.Items.AddRange(Enum.GetNames(typeof(Species)));
            genderComboBox.Items.AddRange(new string[] { "Male", "Female" });
            FatherSerialComboBox.Items.Insert(0, "None");
            MotherSerialComboBox.Items.Insert(0, "None");
        }

        private void BirdsForm_Load(object sender, EventArgs e)
        {
            LoadBirdsList();
        }

        private void LoadBirdsList()
        {
            Birds = SqliteDataAccess.LoadBirds(CageSerial);
            WireUpBirdsList();
        }

        private void WireUpBirdsList()
        {
            BirdGridView.DataSource = Birds;
        }

        private void AddBirdButton_Click(object sender, EventArgs e)
        {
            Bird birdToSave;

            if (FatherSerialComboBox.SelectedItem.ToString() != "None" && MotherSerialComboBox.SelectedItem.ToString() != "None")
            {
                birdToSave = new Bird(serialTextBox.Text, specieComboBox.SelectedItem as string, subSpeciesComboBox.SelectedItem as string,
                    hatchDateTimePicker.Text, genderComboBox.SelectedItem as string, CageSerial,
                    FatherSerialComboBox.SelectedItem as string, MotherSerialComboBox.SelectedItem as string);
            }

            else if (FatherSerialComboBox.SelectedItem.ToString() != "None" && MotherSerialComboBox.SelectedItem.ToString() == "None")
            {
                MessageBox.Show("Father Serial was entred but mother serial wasn't !");
                return;
            }

            else if (FatherSerialComboBox.SelectedItem.ToString() == "None" && MotherSerialComboBox.SelectedItem.ToString() != "None")
            {
                MessageBox.Show("Mother Serial was entred but father serial wasn't !");
                return;
            }

            else
            {
                birdToSave = new Bird(serialTextBox.Text, specieComboBox.SelectedItem as string, subSpeciesComboBox.SelectedItem as string,
                    hatchDateTimePicker.Text, genderComboBox.SelectedItem as string, CageSerial, null,null);
            }

            if (birdToSave != null)
                SqliteDataAccess.SaveBirds(birdToSave);

            LoadBirdsList();
        }

        private void SpecieComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (specieComboBox.SelectedItem.ToString())
            {
                case "American":
                    subSpeciesComboBox.Items.Clear();
                    subSpeciesComboBox.Items.AddRange(Enum.GetNames(typeof(SubSpeciesAM)));
                    break;

                case "European":
                    subSpeciesComboBox.Items.Clear();
                    subSpeciesComboBox.Items.AddRange(Enum.GetNames(typeof(SubSpeciesEU)));
                    break;

                case "Australian":
                    subSpeciesComboBox.Items.Clear();
                    subSpeciesComboBox.Items.AddRange(Enum.GetNames(typeof(SubSpeciesAU)));
                    break;

                default:
                    subSpeciesComboBox.Items.Clear();
                    break;
            }
        }

        private void SerialTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the keypress event
            }
        }

        private void FatherSerialTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the keypress event
            }
        }

        private void MotherSerialtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the keypress event
            }
        }

        public void LoadParentsSerials()
        {
            // Clear existing items before adding new ones
            FatherSerialComboBox.Items.Clear();
            MotherSerialComboBox.Items.Clear();

            List<string> fatherSerials = SqliteDataAccess.GetParentsSerials(CageSerial, subSpeciesComboBox.SelectedItem.ToString(), "Male");
            List<string> motherSerials = SqliteDataAccess.GetParentsSerials(CageSerial, subSpeciesComboBox.SelectedItem.ToString(), "Female");

            // Add the serials to the combo box
            FatherSerialComboBox.Items.AddRange(fatherSerials.ToArray());
            MotherSerialComboBox.Items.AddRange(motherSerials.ToArray());

            // Insert "None" at the beginning
            FatherSerialComboBox.Items.Insert(0, "None");
            MotherSerialComboBox.Items.Insert(0, "None");
        }

        private void SubSpeciesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadParentsSerials();
        }

        private void AddChildToBirdButton_Click(object sender, EventArgs e)
        {
            if (BirdGridView.SelectedRows.Count > 0)
            {
                var selectedRow = BirdGridView.SelectedRows[0].Cells;
                specieComboBox.SelectedItem = selectedRow[1].Value;
                subSpeciesComboBox.SelectedItem = selectedRow[2].Value;

                // TODO : check if child hatch date is earlier than parents hatch date

                FatherSerialComboBox.SelectedItem = null;
                MotherSerialComboBox.SelectedItem = null;

                if (selectedRow[4].Value.ToString() == "Male")
                    FatherSerialComboBox.SelectedItem = selectedRow[0].Value;
                else if (selectedRow[4].Value.ToString() == "Female")
                    MotherSerialComboBox.SelectedItem = selectedRow[0].Value;
            }

            else
            {
                MessageBox.Show("Please select a bird to add child !");
                return;
            }

        }
    }
}
