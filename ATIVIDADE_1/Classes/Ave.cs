using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Ave : Animal 
    {
        private bool rapina;
        private string corPena;

        public bool Rapina { get => rapina; set => rapina = value; }
        public string CorPena { get => corPena; set => corPena = value; }

        public void Ciscar() { }
    }
}