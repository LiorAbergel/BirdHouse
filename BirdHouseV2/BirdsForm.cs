using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BirdHouseV2
{
    public partial class BirdsForm : Form
    {
        public string cageSerial { get; set; }

        List<Bird> Birds = new List<Bird>();
        public BirdsForm(string cageSerial)
        {
            InitializeComponent();

            this.cageSerial = cageSerial;
            LoadBirdsList();
        }

        private void BirdsForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadBirdsList()
        {
            // TODO - Get real data hear
            Birds = SqliteDataAccess.LoadBirds(cageSerial);
            WireUpBirdsList();
        }

        private void WireUpBirdsList()
        {
            BirdGridView.DataSource = Birds;
        }

        private void addBirdButton_Click(object sender, EventArgs e)
        {
            Bird birdToSave = new Bird(serialTextBox.Text, specieComboBox.SelectedItem as string,subSpeciesComboBox.SelectedIndex.ToString(),
                hatchDateTimePicker.Text, genderTextBox.Text, cageSerialTextBox.Text,
                fatherSerialTextBox.Text, motherSerialtextBox.Text);

            SqliteDataAccess.saveBirds(birdToSave);

            LoadBirdsList();
        }
    }
}
