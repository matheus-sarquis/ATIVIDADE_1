using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Mamifero : Animal
    {
        private int qtdMamas;
        private bool pelo;
        private string corPelo;

        public int QtdMamas { get => qtdMamas; set => qtdMamas = value; }
        public bool Pelo { get => pelo; set => pelo = value; }
        public string CorPelo { get => corPelo; set => corPelo = value; }

        public void Amamentar() { }
    }
}