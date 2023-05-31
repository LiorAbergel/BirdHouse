using System;
using System.Windows.Forms;
using DemoLibrary;
using static DemoLibrary.Cage;

namespace BirdHouseV2
{
    public partial class EditCageForm : Form
    {
        public Cage Cage { get; set; }
        public EditCageForm(string cageSerial)
        {
            InitializeComponent();
            Cage = SqliteDataAccess.GetCage(cageSerial);

            SerialNumberTextBox.Text = Cage.Serial;
            LengthTextBox.Text = Cage.Length;
            WidthTextBox.Text = Cage.Width;
            HeightTextBox.Text = Cage.Height;

            var MaterialString = Enum.GetNames(typeof(Materials));
            MaterialComboBox.Items.AddRange(MaterialString);
            MaterialComboBox.SelectedItem = Cage.Material;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
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
                    if (!(char.IsNumber(c)))
                    {
                        MessageBox.Show("Invalid Length! \n just numbers allowed !");
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
                        MessageBox.Show("Invalid Height! \nonly numbers allowed!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Height!");
                return;
            }

            Cage newCage = new Cage(Cage.OwnerID, serial, length, width, height, material);
            SqliteDataAccess.SetCage(Cage.Serial, newCage);

            MessageBox.Show("Cage edited successfully !");
            Close();
        }
    }
}
