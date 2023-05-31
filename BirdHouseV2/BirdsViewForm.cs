using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static DemoLibrary.Bird;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BirdHouseV2
{
    public partial class BirdsViewForm : Form
    {
        public string ownerID { get; set; }
        public string cageSerial { get; set; }
        public List<Bird> Birds { get; set; }
        public bool isCageForm { get; set; }
        public bool isBirdsForm { get; set; }

        public BirdsViewForm(string ownerID, string cageSerial)
        {
            InitializeComponent();

            this.ownerID = ownerID;
            this.cageSerial = cageSerial;
            Birds = new List<Bird>();
            isCageForm = true;
            isBirdsForm = false;

            // Disable cage serial box , it's not needed in this state
            CageSerialLabel.Enabled = false;
            CageSerialLabel.Visible = false;
            CageSerialComboBox.Enabled = false;
            CageSerialComboBox.Visible = false;

            // relocate father and mother serial boxes 
            var fatherLabelOldLocation = FatherSerialLabel.Location;
            var fatherComboBoxOldLocation = FatherSerialComboBox.Location;

            FatherSerialLabel.Location = CageSerialLabel.Location;
            FatherSerialComboBox.Location = CageSerialComboBox.Location;

            MotherSerialLabel.Location = fatherLabelOldLocation;
            MotherSerialComboBox.Location = fatherComboBoxOldLocation;

        }

        public BirdsViewForm(string ownerID, List<Bird> birds)
        {
            InitializeComponent();

            this.ownerID = ownerID;
            Birds = birds;
            cageSerial = null;
            isBirdsForm = true;
            isCageForm = false;

        }

        private void BirdsForm_Load(object sender, EventArgs e)
        {
            LoadBirdsList();

            specieComboBox.Items.AddRange(Enum.GetNames(typeof(Species)));
            genderComboBox.Items.AddRange(new string[] { "Male", "Female" });
            FatherSerialComboBox.Items.Insert(0, "None");
            MotherSerialComboBox.Items.Insert(0, "None");
        }

        private void LoadBirdsList()
        {
            if (isCageForm)
                Birds = SqliteDataAccess.LoadBirds(cageSerial);
            
            WireUpBirdsList();
        }

        private void WireUpBirdsList()
        {
            BirdGridView.DataSource = Birds;
        }


        private void AddBirdButton_Click(object sender, EventArgs e)
        {
            Bird birdToSave;
            string cageSerialInput = isCageForm ? cageSerial :CageSerialComboBox.SelectedItem.ToString() ;

            if (FatherSerialComboBox.SelectedItem?.ToString() != "None" && MotherSerialComboBox.SelectedItem?.ToString() != "None")
            {
                birdToSave = new Bird(serialTextBox.Text, specieComboBox.SelectedItem as string, subSpeciesComboBox.SelectedItem as string,
                    hatchDateTimePicker.Value.Date, genderComboBox.SelectedItem as string, cageSerialInput,
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
                    hatchDateTimePicker.Value.Date, genderComboBox.SelectedItem as string, cageSerialInput, null,null);
            }

            if (birdToSave != null)
            {
                SqliteDataAccess.SaveBirds(birdToSave);
                MessageBox.Show("Bird added successfully !");
            }

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
            // TODO : check if this method works if isBirdsForm

            // Clear existing items before adding new ones
            FatherSerialComboBox.Items.Clear();
            MotherSerialComboBox.Items.Clear();

            string cageSerialInput = null;
            List<string> fatherSerials, motherSerials;

            if (isCageForm)
                cageSerialInput = cageSerial;

            else if (isBirdsForm)
                cageSerialInput = CageSerialComboBox.SelectedItem.ToString();

            if (cageSerialInput != null)
            {
                fatherSerials = SqliteDataAccess.GetParentsSerials(cageSerialInput,
                    subSpeciesComboBox.SelectedItem.ToString(), "Male");

                motherSerials = SqliteDataAccess.GetParentsSerials(cageSerialInput,
                    subSpeciesComboBox.SelectedItem.ToString(), "Female");

                // Add the serials to the combo box
                FatherSerialComboBox.Items.AddRange(fatherSerials.ToArray());
                MotherSerialComboBox.Items.AddRange(motherSerials.ToArray());

                // Insert "None" at the beginning
                FatherSerialComboBox.Items.Insert(0, "None");
                MotherSerialComboBox.Items.Insert(0, "None");
            }
        }

        private void SubSpeciesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isCageForm)
                LoadParentsSerials();
            
            else if (isBirdsForm)
            {
                List<Cage> cages = SqliteDataAccess.LoadCages(ownerID);
                object[] CageSerials = cages.Select(c => c.Serial).ToArray();
                CageSerialComboBox.Items.AddRange(CageSerials);
            }
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
                {
                    if (!FatherSerialComboBox.Items.Contains(selectedRow[0].Value))
                        FatherSerialComboBox.Items.Add(selectedRow[0].Value);

                    FatherSerialComboBox.SelectedItem = selectedRow[0].Value;
                }

                else if (selectedRow[4].Value.ToString() == "Female")
                {
                    if (!MotherSerialComboBox.Items.Contains(selectedRow[0].Value))
                        MotherSerialComboBox.Items.Add(selectedRow[0].Value);

                    MotherSerialComboBox.SelectedItem = selectedRow[0].Value;
                }

                CageSerialComboBox.SelectedItem = selectedRow[5].Value;
            }

            else
            {
                MessageBox.Show("Please select a bird to add child !");
                return;
            }

        }

        private void CageSerialComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadParentsSerials();
        }
    }
}
