using ATIVIDADE_1.Properties;
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
            pAmbiente.BackgroundImage = Resources.FundoGelo;
        }

        private void btnAmbiente2_Click(object sender, EventArgs e)
        {
            pAmbiente.BackgroundImage = Resources.FundoFloresta;
        }

        private void btnAmbiente3_Click(object sender, EventArgs e)
        {
            pAmbiente.BackgroundImage = Resources.FundoFazenda;
        }

        private void cbAnimal_Click(object sender, EventArgs e)
        {
            cbAnimal.Items.Clear();
            //foreach (var item in File.ReadAllLines("Animais.txt"))
            //{
            //    cbAnimal.Items.Add(item);
            //}
            foreach (var item in VG.animais)
            {
                cbAnimal.Items.Add(item.Nome);
            }
        }

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            if (btnMovimentar.Text == "Movimentar")
            {
                btnBaixo.Enabled = true;
                btnCima.Enabled = true;
                btnDireita.Enabled = true;
                btnEsquerda.Enabled = true;
                btnMovimentar.Text = "Parar";
            }
            else
            {
                btnBaixo.Enabled = false;
                btnCima.Enabled = false;
                btnDireita.Enabled = false;
                btnEsquerda.Enabled = false;
                btnMovimentar.Text = "Movimentar";
            }
        }

        public string VerificaPeconhoCarni(Animal animal)
        {
            string texto = "";
            if (animal.Peconhento)
                texto += ", Peçonhento";
            if (animal.Carnivoro)
                texto += ", Carnivoro";
            return texto;
        }

        private void cbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conteudo = "";
            if (cbAnimal.Text != "")
            {
                foreach (var item in VG.animais)
                {
                    if (cbAnimal.Text == item.Nome)
                    {
                        conteudo = $"Nome ->{item.Nome}, Idade ->{item.Idade()}, Sexo ->{item.Sexo} {Environment.NewLine}";//{Environment.NewLine}
                        if (item is Mamifero)
                        {
                            conteudo += $"{(item as Mamifero).QtdMamas} Mamas";
                            if ((item as Mamifero).Pelo)
                                conteudo += $", Cor do Pelo ->{ (item as Mamifero).CorPelo}";
                            else
                                conteudo += $", Não tem pelo";
                        }
                        if (item is Ave)
                        {
                            conteudo += $"Cor da Pena ->{(item as Ave).CorPena}";
                            if ((item as Ave).Rapina)
                                conteudo += ", Rapina";
                        }
                        if (item is Reptil)
                            conteudo += "Possuí Escamas, Possuí Casco";
                        if (item is IAquatico)
                        {
                            if(item is Tubarao)
                                conteudo += $"Vive em Terra";
                            else
                                conteudo += $", Vive em Terra";
                            if ((item as IAquatico).Mergulho)
                                conteudo += $", Mergulha";
                            if ((item as IAquatico).AguaDoce)
                                conteudo += $", É de Água Doce";
                            else
                                conteudo += $", É de Água Salgada";
                        }
                        if (item is IVoar)
                        {
                            conteudo += $", Altitude máxima ->{(item as IVoar).AltitudeMax}m, Velocidade do Voo ->{(item as IVoar).VelocidadeVoo}Km/h";
                        }
                        VerificaPeconhoCarni(item);
                    }
                }
            }
            lblInfo.Text = conteudo;


            if (cbAnimal.Text != "")
            {
                foreach (var item in VG.animais)
                {
                    if (cbAnimal.Text == item.Nome)
                    {
                        if (item is Baleia)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoGelo;
                            pbAnimal.BackgroundImage = Resources.Baleia;
                        }

                        if (item is Cachorro)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Cachorro;
                        }

                        if (item is Coruja)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Coruja;
                        }

                        if (item is Esquilo)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFloresta;
                            pbAnimal.BackgroundImage = Resources.Esquilo;
                        }

                        if (item is Gato)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Gato;
                        }

                        if (item is Gaviao)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFloresta;
                            pbAnimal.BackgroundImage = Resources.Gavião;
                        }

                        if (item is Leao)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFloresta;
                            pbAnimal.BackgroundImage = Resources.Leão;
                        }

                        if (item is Morcego)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Morcego;
                        }

                        if (item is Ornitorrinco)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFloresta;
                            pbAnimal.BackgroundImage = Resources.Ornitorrinco;
                        }

                        if (item is Pato)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Pato;
                        }

                        if (item is Pinguim)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoGelo;
                            pbAnimal.BackgroundImage = Resources.Pinguim;
                        }

                        if (item is Pombo)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Pombo;
                        }

                        if (item is Tartaruga)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Tartaruga;
                        }

                        if (item is Tubarao)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoGelo;
                            pbAnimal.BackgroundImage = Resources.Tubarão;
                        }
                    }
                }
            }

        }

        public void MudaFundo(string fundo)
        {
            switch (fundo)
            {
                case "gelo":
                    pAmbiente.BackgroundImage = Resources.FundoGelo;
                    break;

                case "fazenda":
                    pAmbiente.BackgroundImage = Resources.FundoFazenda;
                    break;

                case "floresta":
                    pAmbiente.BackgroundImage = Resources.FundoFloresta;
                    break;
            }
        }
    }
}