using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            frAddAnimal tela = new frAddAnimal();
            tela.Show();
        }

        private void btnlistagem_Click(object sender, EventArgs e)
        {            
            frListar tela = new frListar();
            tela.Show();
        }

        private void btnAmbiente1_Click(object sender, EventArgs e)
        {
            pbAmbiente1.Visible = true;
            //pbAmbiente2.Visible = false;
            //pbAmbiente3.Visible = false;
        }

        private void btnAmbiente2_Click(object sender, EventArgs e)
        {
            pbAmbiente1.Visible = false;
            //pbAmbiente2.Visible = true;
            //pbAmbiente3.Visible = false;
        }

        private void btnAmbiente3_Click(object sender, EventArgs e)
        {
            pbAmbiente1.Visible = false;
            //pbAmbiente2.Visible = false;
            //pbAmbiente3.Visible = true;
        }

        private void cbAnimal_Click(object sender, EventArgs e)
        {
            cbAnimal.Items.Clear();
            foreach (var item in )
            {
                cbAnimal.Items.Add(item.)
            }
        }
    }
}