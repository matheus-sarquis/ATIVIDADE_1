using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Gaviao : Ave, IVoar, IOviparo, IPredador
    {
        public int altitudeMax { get; set; }
        public double velocidadeVoo { get; set; }

        public void Botar() { }
        public void Chocar() { }
        public void Voar() { }
        public void Atacar() { }
    }
}