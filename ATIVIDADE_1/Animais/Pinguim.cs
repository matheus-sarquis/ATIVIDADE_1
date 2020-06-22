using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Pinguim : Ave, IAquatico, IOviparo
    {
        public bool viveEmT { get; set; }
        public bool mergulho { get; set; }
        public bool aguaDoce { get; set; }

        public void Botar() { }
        public void Chocar() { }
    }
}