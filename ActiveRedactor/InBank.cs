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
    public partial class InBank : Form
    {
        public InBank()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        int indexRow;     
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                table.Rows.Add(BoxId.Text, BoxBank.Text, BoxAccount.Text, BoxSum.Text, BoxCurrency.Text);
            }
            catch
            {
                MessageBox.Show("oops");
            }
            dataGridView1.DataSource = table;

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

        private void InBank_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Bank", typeof(string));
            table.Columns.Add("Account", typeof(int));
            table.Columns.Add("Sum", typeof(int));
            table.Columns.Add("Currency", typeof(string));

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            BoxId.Text = row.Cells[0].Value.ToString();
            BoxBank.Text = row.Cells[1].Value.ToString();
            BoxAccount.Text = row.Cells[2].Value.ToString();
            BoxSum.Text = row.Cells[3].Value.ToString();
            BoxCurrency.Text = row.Cells[4].Value.ToString();
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            try
            {
                newDataRow.Cells[0].Value = BoxId.Text;
                newDataRow.Cells[1].Value = BoxBank.Text;
                newDataRow.Cells[2].Value = BoxAccount.Text;
                newDataRow.Cells[3].Value = BoxSum.Text;
                newDataRow.Cells[4].Value = BoxCurrency.Text;
            }
            catch
            {
                MessageBox.Show("oops");
            }
        }

        private void BoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void BoxAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void BoxSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
