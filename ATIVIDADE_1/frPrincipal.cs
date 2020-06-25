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
            pbAmbiente1.Image = Image.FromFile("FundoNeve.jpeg");
            //pbAmbiente1.Visible = true;
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
            //string texto = VG.arvore.ListagemEmOrdem();
            //string t = texto;
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            Baleia baleia = new Baleia("Baleia", DateTime.Now, 'F');
            VG.arvore.Insere(baleia);

            Cachorro cachorro = new Cachorro("Cachorro", DateTime.Now, 'F');
            VG.arvore.Insere(cachorro);

            Coruja coruja = new Coruja("Coruja", DateTime.Now, 'F');
            VG.arvore.Insere(coruja);

            Esquilo esquilo = new Esquilo("Esquilo", DateTime.Now, 'F');
            VG.arvore.Insere(esquilo);

            Gato gato = new Gato("Gato", DateTime.Now, 'F');
            VG.arvore.Insere(gato);

            Gaviao gaviao = new Gaviao("Gaviao", DateTime.Now, 'F');
            VG.arvore.Insere(gaviao);

            Leao leao = new Leao("Leao", DateTime.Now, 'F');
            VG.arvore.Insere(leao);

            Morcego morcego = new Morcego("Morcego", DateTime.Now, 'F');
            VG.arvore.Insere(morcego);

            Ornitorrinco ornitorrinco = new Ornitorrinco("Ornitorrinco", DateTime.Now, 'F');
            VG.arvore.Insere(ornitorrinco);

            Pato pato = new Pato("Pato", DateTime.Now, 'F');
            VG.arvore.Insere(pato);

            Pinguim pinguim = new Pinguim("Pinguim", DateTime.Now, 'F');
            VG.arvore.Insere(pinguim);

            Pombo pombo = new Pombo("Pombo", DateTime.Now, 'F');
            VG.arvore.Insere(pombo);

            Tartaruga tartaruga = new Tartaruga("Tartaruga", DateTime.Now, 'F');
            VG.arvore.Insere(tartaruga);

            Tubarao tubarao = new Tubarao("Tubarao", DateTime.Now, 'F');
            VG.arvore.Insere(tubarao);
        }
    }
}