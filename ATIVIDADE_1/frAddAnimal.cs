using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            do
            {
                if (txtNome.Text == "" || txtData.Text == "" || txtData.Text == "//" || cbAnimal.Text == "" || cbAnimal.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                    break;
                }
                char sexo = ' ';

                try
                {
                    switch (cbAnimal.SelectedItem)
                    {
                        case "Baleia":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Baleia baleia = new Baleia(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(baleia);
                            break;

                        case "Cachorro":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Cachorro cachorro = new Cachorro(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(cachorro);
                            break;

                        case "Coruja":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Coruja coruja = new Coruja(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(coruja);
                            break;

                        case "Gato":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Gato gato = new Gato(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(gato);
                            break;

                        case "Gavião":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Gaviao gaviao = new Gaviao(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(gaviao);
                            break;

                        case "Leão":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Leao leao = new Leao(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(leao);
                            break;

                        case "Morcego":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Morcego morcego = new Morcego(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(morcego);
                            break;

                        case "Ornitorrinco":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Ornitorrinco ornito = new Ornitorrinco(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(ornito);
                            break;

                        case "Pato":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Pato pato = new Pato(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(pato);
                            break;

                        case "Pinguim":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Pinguim pinguim = new Pinguim(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(pinguim);
                            break;

                        case "Pombo":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Pombo pombo = new Pombo(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(pombo);
                            break;

                        case "Tartaruga":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Tartaruga tartaruga = new Tartaruga(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(tartaruga);
                            break;

                        case "Tubarão":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Tubarao tubarao = new Tubarao(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(tubarao);
                            break;

                        case "Esquilo":
                            if (cbSexo.Text == "Macho")
                                sexo = 'm';
                            else
                                sexo = 'f';
                            Esquilo esquilo = new Esquilo(txtNome.Text, Convert.ToDateTime(txtData.Text), sexo);
                            VG.arvore.Insere(esquilo);
                            break;

                        default:
                            MessageBox.Show("Selecione um Animal");
                            break;
                    }
                    
                }
                catch(Exception excep)
                {
                    MessageBox.Show(excep.Message + $" - ({txtNome.Text})");
                }
                VG.AttAnimais();
                LimpaCampos();
                break;
            } while (1 == 1);
        }

        private void frAddAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("Animais.txt", VG.arvore.ListagemNomesEmOrdem());
        }
    }
}