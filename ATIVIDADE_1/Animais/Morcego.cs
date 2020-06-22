using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Morcego : Mamifero, IVoar, IPredador
    {
        public int altitudeMax { get; set; }
        public double velocidadeVoo { get; set; }

        public void Atacar() { }
        public void Voar() { }        
    }
}