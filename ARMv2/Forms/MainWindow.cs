using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARMv2.Forms;

namespace ARMv2
{
    public partial class MainWindow : Form
    {
        DataSet dataSet = new DataSet();
        public MainWindow()
        {
            PostgresConnector.FirstInitialize(ref dataSet);
            InitializeComponent();
            dataGridView1.DataSource = dataSet.Tables["Амбулаторные карты"].DefaultView;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView2.DataSource = dataSet.Tables["Амбулаторные записи"].DefaultView;
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var collection1 = dataGridView1.SelectedRows[0];
            var collection2 = collection1.Cells;
            var collection3 = (int) collection2[0].Value;
            ShowCardForm form = new ShowCardForm(collection3);
            form.Show();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
            ShowRecordForm form = new ShowRecordForm(id);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            ShowCardForm form = new ShowCardForm(id);
            form.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (dataGridView1.Rows.Count-1==dataGridView1.SelectedRows[0].Index) { dataGridView2.DataSource = dataSet.Tables["Амбулаторные записи"].DefaultView; return; }

            var card = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DataTable records = dataSet.Tables["Амбулаторные записи"];

            var Query = from record in records.AsEnumerable()
                        where record.Field<int>("Карта №") == card
                        orderby record.Field<int>("Запись №") descending
                        select record;
            if (Query.Count() == 0){
                records = new DataTable();
            }
            else { records = Query.CopyToDataTable<DataRow>(); }
            dataGridView2.DataSource = records;
        }

        private void ShowRecordBtn_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
            ShowRecordForm form = new ShowRecordForm(id);
            form.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            (new AboutBox1()).ShowDialog();
        }

        private void ApplyFilter_Click(object sender, EventArgs e)
        {
            string query = "Select id, breeder, address, phone, kindofanimal, breed, petname, dateofbirth, gender, dateoffirst From clientbase";
            Dictionary<string, object> addToQuery = new Dictionary<string, object>();
            if (this.NumFilter.Value != 0) addToQuery.Add("id", NumFilter.Value);
            if (this.PhoneFilter.Text != "") addToQuery.Add("phone",PhoneFilter.Text);
            if (FIOFilter.Text != "") addToQuery.Add("breeder",FIOFilter.Text);
            if (PetFilter.Text != "") addToQuery.Add("petname", PetFilter.Text);
            if (addToQuery.Count != 0) query += " where ";
            int i = 1;
            foreach(KeyValuePair<string, object> row in addToQuery)
            {
                if(row.Key=="id") query+= string.Format("{0} = {1}", row.Key, row.Value);
                else query += string.Format("{0} LIKE '%{1}%'", row.Key, row.Value.ToString());
                if(i!=addToQuery.Count) { i++;  query += " OR "; }
            }

            query += ";";

            dataGridView1.DataSource = PostgresConnector.SelectCard(query);
        }

        private void ClearFilter_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from client in dataSet.Tables["Амбулаторные карты"].AsEnumerable()
                        select client).CopyToDataTable();
            NumFilter.Value = 0;
            PhoneFilter.Text = "";
            FIOFilter.Text = "";
            PetFilter.Text = "";
        }

        private void AddCardBtn_Click(object sender, EventArgs e)
        {
            var form = new NewCardForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                dataSet = new DataSet();
                PostgresConnector.FirstInitialize(ref dataSet);
            }
        }

        private void AddRecBtn_Click(object sender, EventArgs e)
        {
            var form = new NewRecordForm((int)dataGridView1.SelectedRows[0].Cells[0].Value);
            form.ShowDialog();
            PostgresConnector.FirstInitialize(ref dataSet);
        }

        private void EditCardBtn_Click(object sender, EventArgs e)
        {
            int card = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var result = MessageBox.Show(String.Format("Вы действительно хотите отредактировать карту №{0}?", card), "Внимание", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var passForm = new Password();
                passForm.ShowDialog();
                if (passForm.DialogResult == DialogResult.OK)
                {
                    var form = new RedactCardForm((int)dataGridView1.SelectedRows[0].Cells[0].Value);
                    form.Show();
                }
            }
        }

        private void EditRecBtn_Click(object sender, EventArgs e)
        {
            int card = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var result = MessageBox.Show(String.Format("Вы действительно хотите отредактировать запись №{0}?", card), "Внимание", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var passForm = new Password();
                passForm.ShowDialog();
                if (passForm.DialogResult == DialogResult.OK)
                {
                    var form = new RedactRecordForm((int)dataGridView2.SelectedRows[0].Cells[0].Value);
                    form.Show();
                }
            }
        }

        private void DeleteCardBtn_Click(object sender, EventArgs e)
        {
            int card = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var result = MessageBox.Show(String.Format("Вы действительно хотите удалить карту №{0}?", card), "Внимание", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) {
                var form = new Password();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK) PostgresConnector.DeleteCard(card);
            }
            PostgresConnector.FirstInitialize(ref dataSet);
            dataGridView1.Refresh();
        }

        private void DeleteRecBtn_Click(object sender, EventArgs e)
        {
            int record = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
            var result = MessageBox.Show(String.Format("Вы действительно хотите удалить запись №{0}?", record), "Внимание", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var form = new Password();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK) PostgresConnector.DeleteRecord(record);
            }
            PostgresConnector.FirstInitialize(ref dataSet);
            dataGridView2.Refresh();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            var form = new NewCardForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                dataSet = new DataSet();
                PostgresConnector.FirstInitialize(ref dataSet);
            }
        }
    }
}
