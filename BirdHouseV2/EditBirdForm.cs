using DemoLibrary;
using System;
using System.Linq;
using System.Windows.Forms;
using static DemoLibrary.Bird;
using static DemoLibrary.Cage;

namespace BirdHouseV2
{
    public partial class EditBirdForm : Form
    {
        public Bird Bird { get; set; }
        public EditBirdForm(string birdSerial, string ownerID)
        {
            InitializeComponent();

            Bird = SqliteDataAccess.GetBird(birdSerial);

            serialTextBox.Text = birdSerial;

            specieComboBox.Items.AddRange(Enum.GetNames(typeof(Species)));
            specieComboBox.SelectedItem = Bird.Specie;

            hatchDateTimePicker.Value = Bird.HatchDate;

            genderComboBox.Items.AddRange(new string[] { "Male", "Female" });

            var cages = SqliteDataAccess.LoadCages(ownerID);
            CageSerialComboBox.Items.AddRange(cages.Select(c => c.Serial).ToArray());
            CageSerialComboBox.SelectedItem = Bird.CageSerial;

        }

        private void EditBirdForm_Load(object sender, EventArgs e)
        {

        }

        private void specieComboBox_SelectedValueChanged(object sender, EventArgs e)
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
    }
}
