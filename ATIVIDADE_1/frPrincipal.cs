﻿using ATIVIDADE_1.Properties;
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

        private void cbAnimal_Click(object sender, EventArgs e)
        {
            cbAnimal.Items.Clear();
            foreach (var item in VG.animais)
            {
                cbAnimal.Items.Add(item.Nome);
            }
        }

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            if (btnMovimenta.Text == "Movimentar")
            {
                btnBaixo.Enabled = true;
                btnCima.Enabled = true;
                btnDireita.Enabled = true;
                btnEsquerda.Enabled = true;
                btnMovimenta.Text = "Parar";
            }
            else
            {
                btnBaixo.Enabled = false;
                btnCima.Enabled = false;
                btnDireita.Enabled = false;
                btnEsquerda.Enabled = false;
                btnMovimenta.Text = "Movimentar";
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
                            pbAnimal.Location = new Point(237, 278);
                            pbAnimal.Size = new Size(464, 346);
                            MudaBtn("12");
                        }

                        if (item is Cachorro)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Cachorro;
                            pbAnimal.Location = new Point(721, 199);
                            pbAnimal.Size = new Size(196, 173);
                            MudaBtn("126");
                        }

                        if (item is Coruja)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Coruja;
                            pbAnimal.Location = new Point(271, 149);
                            pbAnimal.Size = new Size(209, 185);
                            MudaBtn("13546");
                        }

                        if (item is Esquilo)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFloresta;
                            pbAnimal.BackgroundImage = Resources.Esquilo;
                            pbAnimal.Location = new Point(499, 228);
                            pbAnimal.Size = new Size(152, 144);
                            MudaBtn("12");
                        }

                        if (item is Gato)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Gato;
                            pbAnimal.Location = new Point(721, 199);
                            pbAnimal.Size = new Size(196, 173);
                            MudaBtn("126");
                        }

                        if (item is Gaviao)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFloresta;
                            pbAnimal.BackgroundImage = Resources.Gavião;
                            pbAnimal.Location = new Point(753, 104);
                            pbAnimal.Size = new Size(214, 186);
                            MudaBtn("13456");
                        }

                        if (item is Leao)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFloresta;
                            pbAnimal.BackgroundImage = Resources.Leão;
                            pbAnimal.Location = new Point(433, 238);
                            pbAnimal.Size = new Size(338, 278);
                            MudaBtn("126");
                        }

                        if (item is Morcego)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Morcego;
                            pbAnimal.Location = new Point(271, 149);
                            pbAnimal.Size = new Size(209, 185);
                            MudaBtn("1246");
                        }

                        if (item is Ornitorrinco)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFloresta;
                            pbAnimal.BackgroundImage = Resources.Ornitorrinco;
                            pbAnimal.Location = new Point(424, 328);
                            pbAnimal.Size = new Size(241, 197);
                            MudaBtn("125");
                        }

                        if (item is Pato)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Pato;
                            pbAnimal.Location = new Point(87, 254);
                            pbAnimal.Size = new Size(152, 139);
                            MudaBtn("1354");
                        }

                        if (item is Pinguim)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoGelo;
                            pbAnimal.BackgroundImage = Resources.Pinguim;
                            pbAnimal.Location = new Point(741, 78);
                            pbAnimal.Size = new Size(219, 206);
                            MudaBtn("135");
                        }

                        if (item is Pombo)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Pombo;
                            pbAnimal.Location = new Point(271, 149);
                            pbAnimal.Size = new Size(152, 139);
                            MudaBtn("135");
                        }

                        if (item is Tartaruga)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Tartaruga;
                            pbAnimal.Location = new Point(107, 210);
                            pbAnimal.Size = new Size(241, 197);
                            MudaBtn("15");
                        }

                        if (item is Tubarao)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoGelo;
                            pbAnimal.BackgroundImage = Resources.Tubarão;
                            pbAnimal.Location = new Point(261, 178);
                            pbAnimal.Size = new Size(464, 511);
                            MudaBtn("16");
                        }
                    }
                }
            }
            else
                MudaBtn("");
        }

        public void MudaBtn(string texto)
        {
            btnMovimenta.Enabled = false;
            btnComunica.Enabled = false;
            btnAlimenta.Enabled = false;
            btnAmamenta.Enabled = false;
            btnCisca.Enabled = false;
            btnVoa.Enabled = false;
            btnBota.Enabled = false;
            btnChoca.Enabled = false;
            btnAtaca.Enabled = false;

            if (texto.Contains("1"))//animal
            {
                btnMovimenta.Enabled = true;
                btnComunica.Enabled = true;
                btnAlimenta.Enabled = true;
            }
            if (texto.Contains("2"))//mamifero
            {
                btnAmamenta.Enabled = true;
            }
            if (texto.Contains("3"))//ave
            {
                btnCisca.Enabled = true;
            }
            if (texto.Contains("4"))//Ivoar
            {
                btnVoa.Enabled = true;
            }
            if (texto.Contains("5"))//IOviparo
            {
                btnBota.Enabled = true;
                btnChoca.Enabled = true;
            }
            if (texto.Contains("6"))//IPredador
            {
                btnAtaca.Enabled = true;
            }
        }
    }
}