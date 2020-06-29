﻿using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Ave : Animal 
    {
        #region Variáveis
        private bool rapina;
        private string corPena;

        public bool Rapina { get => rapina; set => rapina = value; }
        public string CorPena { get => corPena; set => corPena = value; }
        #endregion

        public void Ciscar(ref PictureBox picAnimal,string tipoAnimal)
        {
            if (tipoAnimal == "coruja")
            {
                picAnimal.BackgroundImage = Resources.Coruja_ciscando;//amamentar
            }

            if (tipoAnimal == "gaviao")
            {
                picAnimal.BackgroundImage = Resources.Gavião_ciscando;//amamentar
            }

            if (tipoAnimal == "pinguim")
            {
                picAnimal.BackgroundImage = Resources.Pinguim_ciscando;//amamentar
            }

            if (tipoAnimal == "pato")
            {
                picAnimal.BackgroundImage = Resources.Pato_ciscando;//amamentar
            }

            if (tipoAnimal == "pombo")
            {
                picAnimal.BackgroundImage = Resources.Pombo_ciscando;//amamentar
            }
        }
    }
}