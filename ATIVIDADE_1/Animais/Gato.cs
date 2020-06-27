using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Gato : Mamifero
    {
        public Gato(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            QtdMamas = 8;
            Pelo = true;
            CorPelo = "Cinza"; //<------------------------------------------------------------------------------
            Carnivoro = true;
            Peconhento = false;
        }
    }
}