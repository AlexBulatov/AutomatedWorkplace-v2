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
    public partial class RedactRecordForm : Form
    {
        Model.AmbulatorRecord value;
        int id;
        public RedactRecordForm(int id)
        {
            InitializeComponent();
            this.id = id;
            value = PostgresConnector.GetRecord(id);
            Model.AmbulatorCard card= PostgresConnector.GetAmbulatorCard(value.ToCard);
            Breeder.Text = card.Breeder;
            Adress.Text = card.Address;
            Phone.Text = card.Phone;
            KindOfAnimal.Text = card.KindOfAnimal;
            Breed.Text = card.Breed;
            PetName.Text = card.PetName;
            DateTime birth = card.DateOfBirth;
            Birth.Text = birth.ToLongDateString();
            TimeSpan AgeSpan = DateTime.Now - birth;
            Age.Text = String.Format("{0} лет {1} месяцев {2} дней", AgeSpan.Days / 365, (AgeSpan.Days % 365) / 30, (AgeSpan.Days % 365) % 30);
            IsMale.Text = (card.IsMale) ? "Мужская" : "Женская";

            DateOfVisit.Value = value.DateVisit;
            PayBox.Text = value.Payment.ToString();
            Anamnesis.Text = value.anamnesis;
            Clinic.Text = value.assignments;
            Epicrisis.Text = value.epicrisis;
        }

        private void EnterRecord_Click(object sender, EventArgs e)
        {
            value.Payment = Int32.Parse(PayBox.Text);
            value.DateVisit = DateOfVisit.Value;
            value.anamnesis = Anamnesis.Text;
            value.assignments = Clinic.Text;
            value.epicrisis = Epicrisis.Text;
            PostgresConnector.UpdateRecord(value, id);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
