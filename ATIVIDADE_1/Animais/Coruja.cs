using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Coruja : Ave, IOviparo, IVoar, IPredador
    {
        #region Variáveis
        private int altitudeMax;
        private double velocidadeVoo;

        public int AltitudeMax { get => altitudeMax; set => altitudeMax = value; }
        public double VelocidadeVoo { get => velocidadeVoo; set => velocidadeVoo = value; }
        #endregion

        public Coruja(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            Rapina = true;
            CorPena = "Marrom" ; //conferir com a imagem q será utilizada <--------------
            Peconhento = false;
            Carnivoro = true;
            AltitudeMax = 20; //<------------------------
            VelocidadeVoo = 15;
        }

        public void Botar() { }
        public void Chocar() { }
        public void Voar() { }
        public void Atacar() { }
    }
}