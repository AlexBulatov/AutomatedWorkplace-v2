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
    public partial class NewRecordForm : Form
    {
        int id;
        
        public NewRecordForm(int id)
        {
            this.id = id;
            InitializeComponent();
            Model.AmbulatorCard card= PostgresConnector.GetAmbulatorCard(id);
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

        }

        private void EnterRecord_Click(object sender, EventArgs e)
        {
            Model.AmbulatorRecord value = new Model.AmbulatorRecord();
            value.ToCard = id;
            value.DateVisit = DateTime.Now;
            value.Payment = Int32.Parse(PayBox.Text);
            value.assignments = Clinic.Text;
            value.anamnesis = Anamnesis.Text;
            value.epicrisis = Epicrisis.Text;
            value.Debt = 0;
            PostgresConnector.InsertRecord(id, value);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
