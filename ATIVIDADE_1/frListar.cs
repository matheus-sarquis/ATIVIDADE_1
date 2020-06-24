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
    public partial class frListar : Form
    {
        public frListar()
        {
            InitializeComponent();
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            txtGrande.Clear();
            txtGrande.Text = VG.arvore.ListagemNomesEmOrdem();             
        }

        private void btnMamiferos_Click(object sender, EventArgs e)
        {
            txtGrande.Clear();
            txtGrande.Text = VG.arvore.ListagemClassesEmOrdem("Mamifero");
        }

        private void btnOvip_Click(object sender, EventArgs e)
        {
            txtGrande.Clear();
            txtGrande.Text = VG.arvore.ListagemInterfaceEmOrdem("IOviparo");
        }

        private void btnAqua_Click(object sender, EventArgs e)
        {
            txtGrande.Clear();
            txtGrande.Text = VG.arvore.ListagemInterfaceEmOrdem("IAquatico");
        }

        private void btnVoa_Click(object sender, EventArgs e)
        {
            txtGrande.Clear();
            txtGrande.Text = VG.arvore.ListagemInterfaceEmOrdem("IVoar");
        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            txtGrande.Clear();
            txtGrande.Text = VG.arvore.ListagemIdadeEmOrdem();
        }

        private void btnAlfa_Click(object sender, EventArgs e)
        {
            txtGrande.Clear();
            txtGrande.Text = VG.arvore.ListagemNomesEmOrdem();
        }

        private void btnPred_Click(object sender, EventArgs e)
        {
            txtGrande.Clear();
            txtGrande.Text = VG.arvore.ListagemInterfaceEmOrdem("IPredador");
        }
    }
}