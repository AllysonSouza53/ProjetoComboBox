using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoComboBox
{
    public partial class Ttc : Form
    {
        public Ttc()
        {
            InitializeComponent();
        }

        private void Bic_Click(object sender, EventArgs e)
        {
            CBl.Items.Add(Ttexto.Text);
            Qi.Text = CBl.Items.Count.ToString();
            Ttexto.Clear();
            Ttexto.Select();
        }

        private void Boc_Click(object sender, EventArgs e)
        {
            CBl.Sorted = true;
        }

        private void Brc_Click(object sender, EventArgs e)
        {
            if (CBl.SelectedIndex != -1) 
            {
                CBl.Items.RemoveAt(CBl.SelectedIndex);
                Qi.Text = CBl.Items.Count.ToString();
                CBl.ResetText();
            }
        }

        private void Bedc_Click(object sender, EventArgs e)
        {
            if (CBl.SelectedIndex != -1)
            {
                TC.Text = CBl.SelectedItem.ToString();
                Tic.Text = CBl.SelectedItem.ToString();
            }
        }
    }
}
