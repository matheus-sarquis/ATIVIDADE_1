using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Cachorro : Mamifero
    {
        public Cachorro(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            QtdMamas = 8;
            CorPelo = "Marrom";
            Pelo = true;
            Carnivoro = true;
            Peconhento = false;
        }
    }
}