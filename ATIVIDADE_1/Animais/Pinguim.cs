﻿using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Pinguim : Ave, IAquatico, IOviparo
    {
        #region Variáveis
        private bool viveEmT;
        private bool mergulho;
        private bool aguaDoce;

        public bool ViveEmT { get => viveEmT; set => viveEmT = value; }
        public bool Mergulho { get => mergulho; set => mergulho = value; }
        public bool AguaDoce { get => aguaDoce; set => aguaDoce = value; }
        #endregion

        public Pinguim(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            Rapina = false;
            CorPena = "Preta";
            ViveEmT = true;
            Mergulho = true;
            AguaDoce = false;
            Carnivoro = false;
            Peconhento = false;
        }

        public void Botar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Pinguim_com_ovo;
        }
        public void Chocar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Pinguim_chocando;
        }
    }
}