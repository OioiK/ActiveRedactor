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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InBank inBank = new InBank();
            inBank.MdiParent = this;
            inBank.Show();
        }

        private void CassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InCassa inCassa = new InCassa();
            inCassa.MdiParent = this;
            inCassa.Show();
        }

        private void MaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            material.MdiParent = this;
            material.Show();
        }

        private void BuildingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buildings buildings = new Buildings();
            buildings.MdiParent = this;
            buildings.Show();
        }
    }
}
