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
    public partial class ShowRecordForm : Form
    {
        public ShowRecordForm(int id)
        {
            InitializeComponent();
            Model.AmbulatorRecord record = PostgresConnector.GetRecord(id);
            Model.AmbulatorCard card = PostgresConnector.GetAmbulatorCard(record.ToCard);

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
            Visit.Text = record.DateVisit.ToString();
            PayBox.Text = record.Payment.ToString();
            Anamnesis.Text = record.anamnesis;
            Clinic.Text = record.assignments;
            Epicrisis.Text = record.epicrisis;
        }
    }
}
