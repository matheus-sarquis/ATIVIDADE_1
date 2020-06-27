using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Botar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Pombo_com_ovo;
        }
        public void Chocar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Pombo_chocando;
        }
    }
}