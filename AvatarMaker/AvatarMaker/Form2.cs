using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvatarMaker
{
    public partial class Form2 : Form
    {

        BindingSource bs = new BindingSource();

        public Form2()
        {
            InitializeComponent();
            
            bs.DataSource = ListaHeroi.historia;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "nome";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem != null)
                textBox1.Text = listBox1.SelectedItem.ToString();
            
        }

        private void btn_sortAZ_Click(object sender, EventArgs e)
        {
            ListaHeroi.historia.Sort();
            bs.ResetBindings(false);
        }

        private void btn_sortZA_Click(object sender, EventArgs e)
        {
            ListaHeroi.historia.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ListaHeroi.historia.Remove((Heroi) listBox1.SelectedItem);
            bs.ResetBindings(false);
        }
    }
}
