using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationTarasenko
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.database4DataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbFIO.Text;
                nRow[2] = tbAdress.Text;
                nRow[3] = tbTelefon.Text;
                main.database4DataSet.Tables[0].Rows.Add(nRow);
                main.abonentTableAdapter.Update(main.database4DataSet.Abonent);
                main.database4DataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbFIO.Text = "";
                tbAdress.Text = "";
                tbTelefon.Text = "";
            }
        }
    }
}
