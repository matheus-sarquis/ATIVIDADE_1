using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Pato : Ave, IOviparo, IAquatico, IVoar
    {
        public bool viveEmT { get; set; }
        public bool mergulho { get; set; }
        public bool aguaDoce { get; set; }
        public int altitudeMax { get; set; }
        public double velocidadeVoo { get; set; }

        public void Botar() { }
        public void Chocar() { }
        public void Voar() { }
    }
}