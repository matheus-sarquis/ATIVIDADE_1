﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Gaviao : Ave, IVoar, IOviparo, IPredador
    {
        #region Variáveis
        private int altitudeMax;
        private double velocidadeVoo;

        public int AltitudeMax { get => altitudeMax; set => altitudeMax = value; }
        public double VelocidadeVoo { get => velocidadeVoo; set => velocidadeVoo = value; }
        #endregion

        public Gaviao(string nome, DateTime nasc, int idade, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Idade = idade;
            Sexo = sexo;

            Rapina = true;
            CorPena = "Marrom"; //<-------------------------------------
            AltitudeMax = 2400;
            VelocidadeVoo = 320;
            Carnivoro = true;
            Peconhento = false;
        }

        public void Botar() { }
        public void Chocar() { }
        public void Voar() { }
        public void Atacar() { }
    }
}