using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ARMv2.Forms
{
    public partial class PrintForm : Form
    {
        int id;
        public PrintForm(int id)
        {
            this.id = id;
            InitializeComponent();
            Model.AmbulatorRecord record = PostgresConnector.GetRecord(id);
            Model.AmbulatorCard card = PostgresConnector.GetAmbulatorCard(record.ToCard);
            DateOfVisit.Text = record.DateVisit.ToString();
            Assignment.Text = record.assignments;
            Clinic.Text = record.anamnesis;
            Diagnosis.Text = record.epicrisis;

            Breeder.Text = card.Breeder;
            TypeAnimal.Text = card.KindOfAnimal;
            Breed.Text = card.Breed;
            PetName.Text = card.PetName;
            DateTime birth = card.DateOfBirth;
            if (birth == new DateTime(1812, 1, 1)) DateOfBirth.Text = "Неизвестно";
            else DateOfBirth.Text = birth.ToLongDateString();
            IsMale.Text = (card.IsMale) ? "Мужская" : "Женская";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word.Application word = new Word.Application();
            word.Visible = true;
            Word.Document doc = null;

            object fileName = "c:\\Resources\\Shablon.doc";
            object falseValue = false;
            object trueValue = true;
            object missing = Type.Missing;

            object findText = "<Что меняем>";
            object replaceWith = "<На что меняем>";
            object replace = Word.WdReplace.wdReplaceAll;

            doc = word.Documents.Open(ref fileName, ref missing, ref trueValue,
            ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing);

            string[] searches = { "Number", "Owner", "KindOfAnimal", "Breed", "Gender", "Name", "DateOfBirth", "DateOfVisit", "InClinic", "Diagnosis", "Assignment", "Doctor" };
            string[] datas = { id.ToString(), Breeder.Text, TypeAnimal.Text, Breed.Text, IsMale.Text, PetName.Text, DateOfBirth.Text, DateOfVisit.Text, Clinic.Text, Diagnosis.Text, Assignment.Text, Doctor.Text };

            for (int i = 0; i < datas.Length; i++)
            {
                replaceWith = datas[i];
                findText = "<" + searches[i] + ">";

                word.Selection.Find.Execute(ref findText, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceWith, ref replace, ref missing, ref missing, ref missing, ref missing);
            }

            object fileNew = string.Format(@"c:\Resources\print{0}.doc", id);
            doc.SaveAs2(ref fileNew, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);

            object copies = "1";
            object pages = "";
            object range = Word.WdPrintOutRange.wdPrintAllDocument;
            object items = Word.WdPrintOutItem.wdPrintDocumentContent;
            object pageType = Word.WdPrintOutPages.wdPrintAllPages;
            object oTrue = true;
            object oFalse = false;

            doc.PrintOut(ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                            ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                            ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);

            word.Visible = true;
            Close();
        }
    }
}
