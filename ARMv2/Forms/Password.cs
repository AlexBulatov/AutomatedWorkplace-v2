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
    public partial class Password : Form
    {
        private string pass = "341404";
        public Password()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == pass)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неправильный пароль!", "Ошибка", MessageBoxButtons.OK);
            }
            Close();
        }

        private void Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
