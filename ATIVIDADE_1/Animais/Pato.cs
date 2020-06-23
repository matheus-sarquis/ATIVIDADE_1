using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Botar() { }
        public void Chocar() { }
        public void Voar() { }
    }
}