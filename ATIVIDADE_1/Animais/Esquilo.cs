using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Esquilo : Mamifero
    {
        public Esquilo(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            QtdMamas = 8;
            Pelo = true;
            CorPelo = "Marrom";
            Carnivoro = false;
            Peconhento = false;
        }
    }
}