﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Morcego : Mamifero, IVoar, IPredador
    {
        #region Variáveis
        private int altitudeMax;
        private double velocidadeVoo;

        public int AltitudeMax { get => altitudeMax; set => altitudeMax = value; }
        public double VelocidadeVoo { get => velocidadeVoo; set => velocidadeVoo = value; }
        #endregion

        public Morcego(string nome, DateTime nasc, int idade, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Idade = idade;
            Sexo = sexo;

            QtdMamas = 2;
            Pelo = true;
            CorPelo = "Preto";
            AltitudeMax = 10;
            VelocidadeVoo = 130;
            Carnivoro = false;
            Peconhento = false;
        }

        public void Atacar() { }
        public void Voar() { }        
    }
}