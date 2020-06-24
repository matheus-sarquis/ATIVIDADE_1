using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Cachorro : Mamifero, IPredador
    {
        public void Atacar() { }

        public Cachorro(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            QtdMamas = 8;
            CorPelo = "Marrom"; //mudar de acordo com a Imagem <---------------------
            Pelo = true;
            Carnivoro = true;
            Peconhento = false;
        }
    }
}