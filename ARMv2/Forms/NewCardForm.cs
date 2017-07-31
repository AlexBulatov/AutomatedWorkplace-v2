using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMv2
{
    public partial class NewCardForm : Form
    {
        Model.AmbulatorCard value = new Model.AmbulatorCard();
        public NewCardForm()
        {
            InitializeComponent();
            value.IsMale = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            value.Breeder = BreedName.Text;
            value.Address = String.Format("{0}, улица {1}, дом {2}, квартира {3}", this.City.Text, this.Street.Text, this.Home.Text, this.Room.Text);
            value.Phone = Telephone.Text;
            value.Breed = BreedName.Text;
            value.KindOfAnimal = TypeAnimal.Text;
            if (DontHaveBD.Checked) value.DateOfBirth = Model.AmbulatorCard.getBirthFromString(years.Value, months.Value, days.Value);
            else value.DateOfBirth = dateTimePicker2.Value;
            value.PetName = NamePet.Text;
            PostgresConnector.InsertCard(value);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void IsMale_CheckedChanged(object sender, EventArgs e)
        {
            if (IsMale.Checked == true) value.IsMale = true;
        }

        private void IsFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (IsFemale.Checked == true) value.IsMale = false;
        }
    }
}
