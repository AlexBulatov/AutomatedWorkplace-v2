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
    public partial class ShowCardForm : Form
    {
        int id;

        public ShowCardForm(int id)
        {
            this.id = id;
            InitializeComponent();
            Model.AmbulatorCard model = PostgresConnector.GetAmbulatorCard(id);
            DataTable records = PostgresConnector.GetRecordsForCard(id);
            BaseGrid.DataSource = records;
            BreederLabel.Text = model.Breeder;
            AddressLabel.Text = model.Address;
            NumLabel.Text = model.Phone;
            KindOfAnimal.Text = model.KindOfAnimal;
            Breed.Text = model.Breed;
            PetName.Text = model.PetName;
            DateTime birth = model.DateOfBirth;
            Birth.Text = birth.ToLongDateString();
            TimeSpan AgeSpan = DateTime.Now - birth;
            Age.Text = String.Format("{0} лет {1} месяцев {2} дней", AgeSpan.Days / 365, (AgeSpan.Days % 365) / 30, (AgeSpan.Days % 365) % 30);
            IsMale.Text = (model.IsMale) ? "Мужская" : "Женская";
        }

        private void ShowBut_Click(object sender, EventArgs e)
        {

        }

        private void ShowCardForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
