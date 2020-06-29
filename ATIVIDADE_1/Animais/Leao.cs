using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Leao : Mamifero, IPredador
    {
        public Leao(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            QtdMamas = 6;
            Pelo = true;
            CorPelo = "Amarelo";//<-----------------------------
            Carnivoro = true;
            Peconhento = false;
        }

        public void Atacar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Leão_atacando;
        }
    }
}