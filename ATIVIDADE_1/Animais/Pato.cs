using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Pato : Ave, IOviparo, IAquatico, IVoar
    {
        #region Variáveis
        private bool viveEmT;
        private bool mergulho;
        private bool aguaDoce;
        private int altitudeMax;
        private double velocidadeVoo;

        public double VelocidadeVoo { get => velocidadeVoo; set => velocidadeVoo = value; }
        public int AltitudeMax { get => altitudeMax; set => altitudeMax = value; }
        public bool AguaDoce { get => aguaDoce; set => aguaDoce = value; }
        public bool Mergulho { get => mergulho; set => mergulho = value; }
        public bool ViveEmT { get => viveEmT; set => viveEmT = value; }
        #endregion

        public Pato(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            Rapina = false;
            CorPena = "Branco";
            VelocidadeVoo = 52;
            AltitudeMax = 1200;
            AguaDoce = true;
            Mergulho = true;
            viveEmT = true;
            Carnivoro = false;
            Peconhento = false;
        }

        public void Botar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Pato_com_ovo;
        }
        public void Chocar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Pato_chocando;
        }
        public void Voar() { }
    }
}