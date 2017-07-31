using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMv2.Forms
{
    public partial class RedactCardForm : Form
    {
        int id = 0;
        Model.AmbulatorCard value;
        public RedactCardForm(int id)
        {
            InitializeComponent();
            this.id = id;
            value = PostgresConnector.GetAmbulatorCard(id);
            this.Address.Text= value.Address;
            this.BreedName.Text = value.Breeder;
            this.Telephone.Text = value.Phone;
            this.TypeAnimal.Text = value.KindOfAnimal;
            this.dateTimePicker2.Value = value.DateOfBirth;
            this.Breed.Text = value.Breed;
            this.NamePet.Text = value.PetName;
            if (value.IsMale) IsMale.Checked = true;
            else IsFemale.Checked = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            value.Breeder = BreedName.Text;
            value.Address = String.Format(Address.Text);
            value.Phone = Telephone.Text;
            value.Breed = BreedName.Text;
            value.KindOfAnimal = TypeAnimal.Text;
            if (DontHaveBD.Checked) value.DateOfBirth = Model.AmbulatorCard.getBirthFromString(years.Value, months.Value, days.Value);
            else value.DateOfBirth = dateTimePicker2.Value;
            value.PetName = NamePet.Text;
            PostgresConnector.UpdateCard(value, id);
            this.DialogResult = DialogResult.OK;
        }
    }
}
