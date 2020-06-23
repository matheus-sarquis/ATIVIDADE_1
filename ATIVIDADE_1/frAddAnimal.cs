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
    public partial class frAddAnimal : Form
    {
        public frAddAnimal()
        {
            InitializeComponent();
        }

        public void LimpaCampos()
        {
            txtData.Clear();
            txtNome.Clear();
            cbAnimal.Text = "";
            cbSexo.Text = "";
            nupIdade.Value = 0;
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            do
            {
                if(txtNome.Text == "" || txtData.Text == "" || txtData.Text == "//" || cbAnimal.Text == "" || cbAnimal.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                    break;
                }
                switch (cbAnimal.SelectedItem)
                {
                    case "Baleia":
                        Baleia baleia = new Baleia(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            baleia.Sexo = 'm';
                        else
                            baleia.Sexo = 'f';
                        baleia.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(baleia);
                        break;

                    case "Cachorro":
                        Cachorro cachorro = new Cachorro(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            cachorro.Sexo = 'm';
                        else
                            cachorro.Sexo = 'f';
                        cachorro.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(cachorro);
                        break;

                    case "Coruja":
                        Coruja coruja = new Coruja(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            coruja.Sexo = 'm';
                        else
                            coruja.Sexo = 'f';
                        coruja.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(coruja);
                        break;

                    case "Gato":
                        Gato gato = new Gato(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            gato.Sexo = 'm';
                        else
                            gato.Sexo = 'f';
                        gato.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(gato);
                        break;

                    case "Gavião":
                        Gaviao gaviao = new Gaviao(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            gaviao.Sexo = 'm';
                        else
                            gaviao.Sexo = 'f';
                        gaviao.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(gaviao);
                        break;

                    case "Leão":
                        Leao leao = new Leao(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            leao.Sexo = 'm';
                        else
                            leao.Sexo = 'f';
                        leao.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(leao);
                        break;

                    case "Morcego":
                        Morcego morcego = new Morcego(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            morcego.Sexo = 'm';
                        else
                            morcego.Sexo = 'f';
                        morcego.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(morcego);
                        break;

                    case "Ornitorrinco":
                        Ornitorrinco ornitorrinco = new Ornitorrinco(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            ornitorrinco.Sexo = 'm';
                        else
                            ornitorrinco.Sexo = 'f';
                        ornitorrinco.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(ornitorrinco);
                        break;

                    case "Pato":
                        Pato pato = new Pato(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            pato.Sexo = 'm';
                        else
                            pato.Sexo = 'f';
                        pato.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(pato);
                        break;

                    case "Pinguim":
                        Pinguim pinguim = new Pinguim(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            pinguim.Sexo = 'm';
                        else
                            pinguim.Sexo = 'f';
                        pinguim.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(pinguim);
                        break;

                    case "Pombo":
                        Pombo pombo = new Pombo(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            pombo.Sexo = 'm';
                        else
                            pombo.Sexo = 'f';
                        pombo.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(pombo);
                        break;

                    case "Tartaruga":
                        Tartaruga tartaruga = new Tartaruga(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            tartaruga.Sexo = 'm';
                        else
                            tartaruga.Sexo = 'f';
                        tartaruga.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(tartaruga);
                        break;

                    case "Tubarão":
                        Tubarao tubarao = new Tubarao(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            tubarao.Sexo = 'm';
                        else
                            tubarao.Sexo = 'f';
                        tubarao.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(tubarao);
                        break;

                    case "Esquilo":
                        Esquilo esquilo = new Esquilo(txtNome.Text, Convert.ToDateTime(txtData.Text));
                        if (cbSexo.Text == "Macho")
                            esquilo.Sexo = 'm';
                        else
                            esquilo.Sexo = 'f';
                        esquilo.Idade = Convert.ToInt32(nupIdade.Value);
                        VG.arvore.Insere(esquilo);
                        break;

                    default:
                        MessageBox.Show("Selecione um Animal");
                        break;
                }
                LimpaCampos();
            } while (1 == 1);
        }
    }
}