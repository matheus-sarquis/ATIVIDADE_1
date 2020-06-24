using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Pombo : Ave, IOviparo
    {
        public Pombo(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            Rapina = false;
            CorPena = "Cinza";
            Carnivoro = false;
            Peconhento = false;
        }

        public void Chocar() { }
        public void Botar() { }
    }
}