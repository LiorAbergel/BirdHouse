using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BirdHouse.Forms
{
    public partial class AddBirdForm : Form
    {
        public AddBirdForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddBirdButton_Click(object sender, EventArgs e)
        {
            string? kind = kindComboBox.SelectedItem as string;
            string? subKind = subKindComboBox.SelectedItem as string;
            if (kind == null)
            {
                MessageBox.Show("Enter Species!");
                return;
            }

            if (subKind == null)
            {
                MessageBox.Show("Enter Sub Species!");
                return;
            }
            
            string? serialNumber = serialNumberBoxTextBox.Text;
            if (serialNumber.Length > 0)
            {
                foreach (char c in serialNumber)
                {

                    if (!(char.IsNumber(c)))
                    {
                        MessageBox.Show("Invalide serial! \njust numbers allowed!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter Serial!");
                return;
            }

            string? cageNumber = cageNumberTextBox.Text;
            if (cageNumber.Length > 0)
            {
                foreach (char c in cageNumber)
                {

                    if (!(char.IsNumber(c) || char.IsLetter(c)))
                    {
                        MessageBox.Show("Invalide cageNumber! \njust numbers and letters allowed!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter Cage Number!");
                return;
            }
            string? dadSerial = dadSerialTextBox.Text;
            if (dadSerial.Length > 0)
            {
                foreach (char c in dadSerial)
                {

                    if (!(char.IsNumber(c)))
                    {
                        MessageBox.Show("Invalide Dad Serial! \njust numbers allowed!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter Dad Serial!");
                return;
            }
            string? momSerial = momSerialTextBox.Text;
            if (momSerial.Length > 0)
            {
                foreach (char c in momSerial)
                {

                    if (!(char.IsNumber(c)))
                    {
                        MessageBox.Show("Invalide Mom Serial! \njust numbers allowed!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter Mom Serial!");
                return;
            }
            DateTime HatchDate = hatchDateTimePicker.Value;
            if (!(DateTime.TryParse(hatchDateTimePicker.Value.ToString(), out HatchDate)))
            {
                MessageBox.Show("Invalide Hatch Date! \npick Hatch Date!");
                return;
            }
            string? sex;
            if (SexButton.Checked)
                sex = SexButton.Text;
            else if (SexButton2.Checked)
                sex = SexButton2.Text;
            else
            {
                MessageBox.Show("Invalide Sex! \npick the bird Sex!");
                return;
            }
                Bird bird_test = new Bird(serialNumber, kind, subKind, HatchDate, sex,
                    cageNumber, dadSerial, momSerial);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubSpeciesComboBox();
        }

        private void AddBirdForm_Load(object sender, EventArgs e)
        {
            var SpeciesString = Enum.GetNames(typeof(Species));
            kindComboBox.Items.AddRange(SpeciesString);
            kindComboBox.SelectedIndex = 0; // Select the first item by default
            UpdateSubSpeciesComboBox();


        }

        private void serialNumberBoxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subKindComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sexTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hatchDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void UpdateSubSpeciesComboBox()
        {
            subKindComboBox.Items.Clear();

            if (kindComboBox.SelectedItem == null)
                return;

            string selectedKind = kindComboBox.SelectedItem.ToString();

            switch (selectedKind)
            {
                case "American":
                    var subSpeciesAMString = Enum.GetNames(typeof(SubSpeciesAM));
                    subKindComboBox.Items.AddRange(subSpeciesAMString);
                    break;
                case "European":
                    var subSpeciesEUString = Enum.GetNames(typeof(SubSpeciesEU));
                    subKindComboBox.Items.AddRange(subSpeciesEUString);
                    break;
                case "Australian":
                    var subSpeciesAUString = Enum.GetNames(typeof(SubSpeciesAU));
                    subKindComboBox.Items.AddRange(subSpeciesAUString);
                    break;
                default:
                    break;
            }
        }
    }
}
