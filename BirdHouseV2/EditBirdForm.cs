using DemoLibrary;
using System;
using System.Linq;
using System.Windows.Forms;
using static DemoLibrary.Bird;
using static DemoLibrary.Cage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BirdHouseV2
{
    public partial class EditBirdForm : Form
    {
        public Bird Bird { get; set; }
        public string OwnerID { get; set; }

        public EditBirdForm(string birdSerial, string ownerID)
        {
            InitializeComponent();

            Bird = SqliteDataAccess.GetBird(birdSerial);
            OwnerID = ownerID;

            serialTextBox.Text = birdSerial;

            specieComboBox.Items.AddRange(Enum.GetNames(typeof(Species)));
            specieComboBox.SelectedItem = Bird.Specie;

            subSpeciesComboBox.SelectedItem = Bird.SubSpecie;

            hatchDateTimePicker.Value = Bird.HatchDate;

            genderComboBox.Items.AddRange(new string[] { "Male", "Female" });
            genderComboBox.SelectedItem = Bird.Gender;

            var cages = SqliteDataAccess.LoadCages(ownerID);
            CageSerialComboBox.Items.AddRange(cages.Select(c => c.Serial).ToArray());
            CageSerialComboBox.SelectedItem = Bird.CageSerial;

            FatherSerialComboBox.Items.Add("None");
            if (Bird.FatherSerial != null)
            {
                FatherSerialComboBox.Items.Add(Bird.FatherSerial);
                FatherSerialComboBox.SelectedItem = Bird.FatherSerial;
            }

            MotherSerialComboBox.Items.Add("None");
            if (Bird.MotherSerial != null)
            {
                MotherSerialComboBox.Items.Add(Bird.MotherSerial);
                MotherSerialComboBox.SelectedItem = Bird.MotherSerial;
            }
        }

        private void specieComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void CageSerialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CageSerialComboBox.SelectedItem.ToString() != Bird.CageSerial) 
            {
                FatherSerialComboBox.Items.Clear();
                FatherSerialComboBox.Items.AddRange(SqliteDataAccess.GetParentsSerials(CageSerialComboBox.SelectedItem.ToString(),
                    subSpeciesComboBox.SelectedItem.ToString(), "Male").ToArray());
                 
                MotherSerialComboBox.Items.Clear();
                MotherSerialComboBox.Items.AddRange(SqliteDataAccess.GetParentsSerials(CageSerialComboBox.SelectedItem.ToString(),
                    subSpeciesComboBox.SelectedItem.ToString(), "Female").ToArray());
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string cageSerialInput = CageSerialComboBox.Text;
            string serialInput = serialTextBox.Text;

            if (serialInput != Bird.Serial && SqliteDataAccess.IsBirdSerialExist(OwnerID, serialTextBox.Text))
            {
                MessageBox.Show("You already have a bird with this serial, please enter a different serial number");
                return;
            }

            // if the user selected "None" in one of the parent's combo boxes , null value will be assigned
            string fatherSerialInput = FatherSerialComboBox.SelectedItem?.ToString() != "None" ?
                FatherSerialComboBox.SelectedItem?.ToString() : null;
            string motherSerialInput = MotherSerialComboBox.SelectedItem?.ToString() != "None" ?
                MotherSerialComboBox.SelectedItem?.ToString() : null;
            DateTime hatchDateInput = hatchDateTimePicker.Value.Date;

            if (fatherSerialInput != null && motherSerialInput == null)
            {
                MessageBox.Show("Father Serial was entred but mother serial wasn't !");
                return;
            }

            else if (fatherSerialInput == null && motherSerialInput != null)
            {
                MessageBox.Show("Mother Serial was entred but father serial wasn't !");
                return;
            }

            // if the user entered a father and a mother, check if their hatch dates are earlier than child
            else if (fatherSerialInput != null && motherSerialInput != null)
            {
                Bird Father = SqliteDataAccess.GetBird(fatherSerialInput);
                Bird Mother = SqliteDataAccess.GetBird(motherSerialInput);

                if (hatchDateInput <= Father.HatchDate)
                {
                    MessageBox.Show("Child hatch date can't be earlier than his father !");
                    return;
                }

                else if (hatchDateInput <= Mother.HatchDate)
                {
                    MessageBox.Show("Child hatch date can't be earlier than his mother !");
                    return;
                }
            }

            // check if hatch date input is later than today
            if (hatchDateInput > DateTime.Now.Date)
            {
                MessageBox.Show("Hatch date can't be later than today !");
                return;
            }

            string specieInput = specieComboBox.SelectedItem as string,
                subSpecieInput = subSpeciesComboBox.SelectedItem as string, genderInput = genderComboBox.SelectedItem as string;

            Bird birdToSave = null;
            if (serialInput != null && specieInput != null && subSpecieInput != null && hatchDateInput != null &&
                genderInput != null && cageSerialInput != null)
            {
                birdToSave = new Bird(serialInput, specieInput, subSpecieInput, hatchDateInput, genderInput,
                                cageSerialInput, fatherSerialInput, motherSerialInput);
            }

            if (birdToSave != null)
            {
                SqliteDataAccess.SetBird(Bird.Serial, birdToSave);
                MessageBox.Show("Bird edited successfully !");
                Close();
            }

            else
            {
                MessageBox.Show("One or more of the fields was not entered , please try again !");
                return;
            }
        }
    }
}
