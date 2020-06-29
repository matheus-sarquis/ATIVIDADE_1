using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Morcego : Mamifero, IVoar
    {
        #region Variáveis
        private int altitudeMax;
        private double velocidadeVoo;

        public int AltitudeMax { get => altitudeMax; set => altitudeMax = value; }
        public double VelocidadeVoo { get => velocidadeVoo; set => velocidadeVoo = value; }
        #endregion

        public Morcego(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            QtdMamas = 2;
            Pelo = true;
            CorPelo = "Preto";
            AltitudeMax = 10;
            VelocidadeVoo = 130;
            Carnivoro = false;
            Peconhento = false;
        }

        public void Voar(ref PictureBox picAnimal)
        {
            picAnimal.Top = 0;
        }
    }
}