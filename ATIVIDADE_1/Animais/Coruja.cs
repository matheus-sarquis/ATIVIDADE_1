using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Coruja : Ave, IOviparo, IVoar
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
            CorPena = "Marrom" ; 
            Peconhento = false;
            Carnivoro = true;
            AltitudeMax = 20; 
            VelocidadeVoo = 15;
        }

        public void Botar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Coruja_com_ovo;
        }

        public void Chocar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Coruja_chocando;
        }

        public void Voar(ref PictureBox picAnimal)
        {
            picAnimal.Top = 0;
        }        
    }
}