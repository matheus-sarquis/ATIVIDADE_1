using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Leao : Mamifero, IPredador
    {
        public Leao(string nome, DateTime nasc, int idade, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Idade = idade;
            Sexo = sexo;

            QtdMamas = 6;
            Pelo = true;
            CorPelo = "Amarelo";//<-----------------------------
            Carnivoro = true;
            Peconhento = false;
        }

        public void Atacar() { }
    }
}