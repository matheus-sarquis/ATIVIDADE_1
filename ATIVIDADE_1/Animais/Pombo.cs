using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Pombo : Ave, IOviparo, IVoar
    {
        #region Variáveis
        private int altitudeMax;
        private double velocidadeVoo;

        public int AltitudeMax { get => altitudeMax; set => altitudeMax = value; }
        public double VelocidadeVoo { get => velocidadeVoo; set => velocidadeVoo = value; }
        #endregion

        public Pombo(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;
            AltitudeMax = 2000;
            VelocidadeVoo = 30;
            Rapina = false;
            CorPena = "Cinza";
            Carnivoro = false;
            Peconhento = false;
        }

        public void Voar() { }

        public void Botar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Pombo_com_ovo;
        }
        public void Chocar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Pombo_chocando;
        }
    }
}