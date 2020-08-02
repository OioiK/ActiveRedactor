using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveRedactor
{
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private int indexRow;
        private void Material_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Weight", typeof(int));
            table.Columns.Add("Year", typeof(int));
            table.Columns.Add("S_Value", typeof(int));
            table.Columns.Add("O_Value", typeof(int));
            table.Columns.Add("R_Value", typeof(int));

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            boxId.Text = row.Cells[0].Value.ToString();
            boxName.Text = row.Cells[1].Value.ToString();
            boxWeight.Text = row.Cells[2].Value.ToString();
            boxYear.Text = row.Cells[3].Value.ToString();
            boxSvalue.Text = row.Cells[4].Value.ToString();
            boxOvalue.Text = row.Cells[5].Value.ToString();
            boxRvalue.Text = row.Cells[6].Value.ToString();
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];

            newDataRow.Cells[0].Value = boxId.Text;
            newDataRow.Cells[1].Value = boxName.Text;
            newDataRow.Cells[2].Value = boxWeight.Text;
            newDataRow.Cells[3].Value = boxYear.Text;
            newDataRow.Cells[4].Value = boxSvalue.Text;
            newDataRow.Cells[5].Value = boxOvalue.Text;
            newDataRow.Cells[6].Value = boxRvalue.Text;

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("oops");
            }
            else
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            try
            {
                table.Rows.Add(boxId.Text, boxName.Text, boxWeight.Text, boxYear.Text, boxSvalue.Text, boxOvalue.Text, boxRvalue.Text);
            }
            catch
            {
                MessageBox.Show("oops");
            }
            dataGridView1.DataSource = table;

        }

        private void boxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void boxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void boxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void boxSvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void boxOvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void boxRvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
