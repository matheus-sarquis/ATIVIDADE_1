using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Gaviao(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            Rapina = true;
            CorPena = "Marrom"; //<-------------------------------------
            AltitudeMax = 2400;
            VelocidadeVoo = 320;
            Carnivoro = true;
            Peconhento = false;
        }

        public void Botar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Gavião_com_ovo;
        }

        public void Chocar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Gavião_chocando;
        }

        public void Voar() { }

        public void Atacar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Gavião_atacando;
        }
    }
}