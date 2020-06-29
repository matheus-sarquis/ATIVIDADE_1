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

        #region metodos
        public void MudaBtn(string texto)
        {
            btnMovimenta.Text = "Movimentar";
            btnEsquerda.Enabled = false;
            btnDireita.Enabled = false;
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
        
        public string VerificaPeconhoCarni(Animal animal)
        {
            string texto = "";
            if (animal.Peconhento)
                texto += ", Peçonhento";
            if (animal.Carnivoro)
                texto += ", Carnivoro";
            return texto;
        }
        #endregion        

        #region combo
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
                            if (item is Tubarao)
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
                            pbAnimal.Location = new Point(490, 199);
                            pbAnimal.Size = new Size(196, 173);
                            MudaBtn("12");
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
                            pbAnimal.Location = new Point(499, 350);
                            pbAnimal.Size = new Size(152, 144);
                            MudaBtn("12");
                        }

                        if (item is Gato)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Gato;
                            pbAnimal.Location = new Point(721, 199);
                            pbAnimal.Size = new Size(196, 173);
                            MudaBtn("12");
                        }

                        if (item is Gaviao)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFloresta;
                            pbAnimal.BackgroundImage = Resources.Gavião;
                            pbAnimal.Location = new Point(753, 300);
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
                            MudaBtn("124");
                        }

                        if (item is Ornitorrinco)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFloresta;
                            pbAnimal.BackgroundImage = Resources.Ornitorrinco;
                            pbAnimal.Location = new Point(424, 328);
                            pbAnimal.Size = new Size(241, 197);
                            MudaBtn("125");
                            btnChoca.Enabled = false;
                        }

                        if (item is Pato)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Pato;
                            pbAnimal.Location = new Point(200, 254);
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
                            pbAnimal.Location = new Point(300, 200);
                            pbAnimal.Size = new Size(152, 139);
                            MudaBtn("1354");
                        }

                        if (item is Tartaruga)
                        {
                            pAmbiente.BackgroundImage = Resources.FundoFazenda;
                            pbAnimal.BackgroundImage = Resources.Tartaruga;
                            pbAnimal.Location = new Point(200, 210);
                            pbAnimal.Size = new Size(241, 197);
                            MudaBtn("15");
                            btnChoca.Enabled = false;
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

        private void cbAnimal_Click(object sender, EventArgs e)
        {
            cbAnimal.Items.Clear();
            foreach (var item in VG.animais)
            {
                cbAnimal.Items.Add(item.Nome);
            }
        }
        #endregion

        #region clicks btn prontos
        private void btnChoca_Click(object sender, EventArgs e)
        {
            foreach (var item in VG.animais)
            {
                if (cbAnimal.Text == item.Nome)
                {
                    if (item is Coruja)                    
                        (item as Coruja).Chocar(ref pbAnimal);
                    
                    if (item is Gaviao)                    
                        (item as Gaviao).Chocar(ref pbAnimal);
                    
                    if (item is Pato)                    
                        (item as Pato).Chocar(ref pbAnimal);
                    
                    if (item is Pinguim)                    
                        (item as Pinguim).Chocar(ref pbAnimal);
                    
                    if (item is Pombo)                    
                        (item as Pombo).Chocar(ref pbAnimal);                    
                }
            }     
        }

        private void btnlistagem_Click(object sender, EventArgs e)
        {
            frListar tela = new frListar();
            tela.Show();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            frAddAnimal tela = new frAddAnimal();
            tela.Show();
        }

        private void btnBota_Click(object sender, EventArgs e)
        {
            foreach (var item in VG.animais)
            {
                if (cbAnimal.Text == item.Nome)
                {
                    if (item is Coruja)
                        (item as Coruja).Botar(ref pbAnimal);

                    if (item is Gaviao)
                        (item as Gaviao).Botar(ref pbAnimal);

                    if (item is Ornitorrinco)
                        (item as Ornitorrinco).Botar(ref pbAnimal);

                    if (item is Pato)
                        (item as Pato).Botar(ref pbAnimal);

                    if (item is Pinguim)
                        (item as Pinguim).Botar(ref pbAnimal);

                    if (item is Pombo)
                        (item as Pombo).Botar(ref pbAnimal);

                    if (item is Tartaruga)
                        (item as Tartaruga).Botar(ref pbAnimal);
                }
            }
        }

        private void btnAlimenta_Click(object sender, EventArgs e)
        {
            foreach (var item in VG.animais)
            {
                if (cbAnimal.Text == item.Nome)
                {
                    if (item is Coruja)
                        (item as Coruja).Alimentar(ref pbAnimal, "coruja");

                    if (item is Gaviao)
                        (item as Gaviao).Alimentar(ref pbAnimal, "gaviao");

                    if (item is Ornitorrinco)
                        (item as Ornitorrinco).Alimentar(ref pbAnimal, "ornitorrinco");

                    if (item is Pato)
                        (item as Pato).Alimentar(ref pbAnimal, "pato");

                    if (item is Pinguim)
                        (item as Pinguim).Alimentar(ref pbAnimal, "pinguim");

                    if (item is Pombo)
                        (item as Pombo).Alimentar(ref pbAnimal, "pombo");

                    if (item is Tartaruga)
                        (item as Tartaruga).Alimentar(ref pbAnimal, "tartaruga");

                    if (item is Baleia)
                        (item as Baleia).Alimentar(ref pbAnimal, "baleia");

                    if (item is Cachorro)
                        (item as Cachorro).Alimentar(ref pbAnimal, "cachorro");

                    if (item is Esquilo)
                        (item as Esquilo).Alimentar(ref pbAnimal, "esquilo");

                    if (item is Gato)
                        (item as Gato).Alimentar(ref pbAnimal, "gato");

                    if (item is Tubarao)
                        (item as Tubarao).Alimentar(ref pbAnimal, "tubarao");

                    if (item is Leao)
                        (item as Leao).Alimentar(ref pbAnimal, "leao");

                    if (item is Morcego)
                        (item as Morcego).Alimentar(ref pbAnimal, "morcego");
                }
            }
        }

        private void btnComunica_Click(object sender, EventArgs e)
        {
            foreach (var item in VG.animais)
            {
                if (cbAnimal.Text == item.Nome)
                {
                    if (item is Coruja)
                        (item as Coruja).Comunicar(ref pbAnimal, "coruja");

                    if (item is Gaviao)
                        (item as Gaviao).Comunicar(ref pbAnimal, "gaviao");

                    if (item is Ornitorrinco)
                        (item as Ornitorrinco).Comunicar(ref pbAnimal, "ornitorrinco");

                    if (item is Pato)
                        (item as Pato).Comunicar(ref pbAnimal, "pato");

                    if (item is Pinguim)
                        (item as Pinguim).Comunicar(ref pbAnimal, "pinguim");

                    if (item is Pombo)
                        (item as Pombo).Comunicar(ref pbAnimal, "pombo");

                    if (item is Tartaruga)
                        (item as Tartaruga).Comunicar(ref pbAnimal, "tartaruga");

                    if (item is Baleia)
                        (item as Baleia).Comunicar(ref pbAnimal, "baleia");

                    if (item is Cachorro)
                        (item as Cachorro).Comunicar(ref pbAnimal, "cachorro");

                    if (item is Esquilo)
                        (item as Esquilo).Comunicar(ref pbAnimal, "esquilo");

                    if (item is Gato)
                        (item as Gato).Comunicar(ref pbAnimal, "gato");

                    if (item is Tubarao)
                        (item as Tubarao).Comunicar(ref pbAnimal, "tubarao");

                    if (item is Leao)
                        (item as Leao).Comunicar(ref pbAnimal, "leao");

                    if (item is Morcego)
                        (item as Morcego).Comunicar(ref pbAnimal, "morcego");
                }
            }
        }

        private void btnAmamenta_Click(object sender, EventArgs e)
        {
            foreach (var item in VG.animais)
            {
                if (cbAnimal.Text == item.Nome)
                {
                    if (item is Baleia)
                        (item as Baleia).Amamentar("baleia", ref pbAnimal);

                    if (item is Cachorro)
                        (item as Cachorro).Amamentar("cachorro", ref pbAnimal);

                    if (item is Esquilo)
                        (item as Esquilo).Amamentar("esquilo", ref pbAnimal);

                    if (item is Gato)
                        (item as Gato).Amamentar("gato", ref pbAnimal);

                    if (item is Leao)
                        (item as Leao).Amamentar("leao", ref pbAnimal);

                    if (item is Morcego)
                        (item as Morcego).Amamentar("morcego", ref pbAnimal);

                    if (item is Ornitorrinco)
                        (item as Ornitorrinco).Amamentar("ornitorrinco", ref pbAnimal);
                }
            }
        }

        private void btnAtaca_Click(object sender, EventArgs e)
        {
            foreach (var item in VG.animais)
            {
                if (cbAnimal.Text == item.Nome)
                {
                    if (item is Gaviao)
                        (item as Gaviao).Atacar(ref pbAnimal);

                    if (item is Leao)
                        (item as Leao).Atacar(ref pbAnimal);

                    if (item is Tubarao)
                        (item as Tubarao).Atacar(ref pbAnimal);
                }
            }
        }

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            if (btnMovimenta.Text == "Movimentar")
            {
                Point posicao = new Point(pbAnimal.Location.X, pbAnimal.Location.Y);
                cbAnimal_SelectedIndexChanged(sender, e);
                pbAnimal.Location = posicao;
                btnAtaca.Enabled = false;
                btnBota.Enabled = false;
                btnComunica.Enabled = false;
                btnChoca.Enabled = false;
                btnVoa.Enabled = false;
                btnAmamenta.Enabled = false;
                btnAlimenta.Enabled = false;
                btnCisca.Enabled = false;
                btnDireita.Enabled = true;
                btnEsquerda.Enabled = true;
                btnMovimenta.Text = "Parar";
            }
            else
            {
                Point posicao = new Point(pbAnimal.Location.X, pbAnimal.Location.Y);
                cbAnimal_SelectedIndexChanged(sender, e);
                pbAnimal.Location = posicao;
                btnDireita.Enabled = false;
                btnEsquerda.Enabled = false;
                btnMovimenta.Text = "Movimentar";
            }
        }

        private void btnCisca_Click(object sender, EventArgs e)
        {
            foreach (var item in VG.animais)
            {
                if (cbAnimal.Text == item.Nome)
                {
                    if (item is Coruja)
                        (item as Coruja).Ciscar(ref pbAnimal, "coruja");

                    if (item is Gaviao)
                        (item as Gaviao).Ciscar(ref pbAnimal, "gaviao");

                    if (item is Pombo)
                        (item as Pombo).Ciscar(ref pbAnimal, "pombo");

                    if (item is Pato)
                        (item as Pato).Ciscar(ref pbAnimal, "pato");

                    if (item is Pinguim)
                        (item as Pinguim).Ciscar(ref pbAnimal, "pinguim");
                }
            }
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            if (pbAnimal.Location.X < 770)
            {
                pbAnimal.Left += 30;
            }
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            foreach (var item in VG.animais)
            {
                if (cbAnimal.Text == item.Nome)
                {
                    if (item is Baleia)
                    {
                        if (pbAnimal.Location.X > 30)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Cachorro)
                    {
                        if (pbAnimal.Location.Y > 254)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Coruja)
                    {
                        if (pbAnimal.Location.X > 254)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Esquilo)
                    {
                        if (pbAnimal.Location.X > 402)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Gato)
                    {
                        if (pbAnimal.Location.X > 254)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Gaviao)
                    {
                        if (pbAnimal.Location.X > 402)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Leao)
                    {
                        if (pbAnimal.Location.X > 402)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Morcego)
                    {
                        if (pbAnimal.Location.X > 254)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Ornitorrinco)
                    {
                        if (pbAnimal.Location.X > 402)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Pato)
                    {
                        if (pbAnimal.Location.X > 254)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Pinguim)
                    {
                        if (pbAnimal.Location.X > 749)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Pombo)
                    {
                        if (pbAnimal.Location.X > 254)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Tartaruga)
                    {
                        if (pbAnimal.Location.X > 254)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                    if (item is Tubarao)
                    {
                        if (pbAnimal.Location.X > 0)
                        {
                            pbAnimal.Left -= 30;
                        }
                    }
                }
            }
        }

        private void btnVoa_Click(object sender, EventArgs e)
        {
            if (btnVoa.Text == "Voar")
            {
                Point posicao = new Point(pbAnimal.Location.X, pbAnimal.Location.Y);
                cbAnimal_SelectedIndexChanged(sender, e);
                pbAnimal.Location = posicao;
                foreach (var item in VG.animais)
                {
                    if (cbAnimal.Text == item.Nome)
                    {
                        if (item is Coruja)
                            (item as Coruja).Voar(ref pbAnimal);

                        if (item is Gaviao)
                            (item as Gaviao).Voar(ref pbAnimal);

                        if (item is Pombo)
                            (item as Pombo).Voar(ref pbAnimal);

                        if (item is Pato)
                            (item as Pato).Voar(ref pbAnimal);

                        if (item is Morcego)
                            (item as Morcego).Voar(ref pbAnimal);
                    }
                }
                btnAtaca.Enabled = false;
                btnBota.Enabled = false;
                btnComunica.Enabled = false;
                btnChoca.Enabled = false;
                btnAmamenta.Enabled = false;
                btnAlimenta.Enabled = false;
                btnCisca.Enabled = false;
                btnMovimenta.Enabled = false;
                btnVoa.Text = "Pousar";
            }
            else
            {
                Point posicao = new Point(pbAnimal.Location.X);
                cbAnimal_SelectedIndexChanged(sender, e);
                posicao.Y = pbAnimal.Location.Y;
                pbAnimal.Location = posicao;
                btnVoa.Text = "Voar";
            }
        }
        #endregion        
    }
}