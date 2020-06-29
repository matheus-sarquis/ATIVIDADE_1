using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Tartaruga : Reptil, IAquatico, IOviparo
    {
        #region Variáveis
        private bool viveEmT;
        private bool mergulho;
        private bool aguaDoce;

        public bool Mergulho { get => mergulho; set => mergulho = value; }
        public bool AguaDoce { get => aguaDoce; set => aguaDoce = value; }
        public bool ViveEmT { get => viveEmT; set => viveEmT = value; }
        #endregion

        public Tartaruga(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            Escamas = false;
            Casco = true;
            Mergulho = true;
            ViveEmT = true;
            AguaDoce = true;
            Carnivoro = true;
            Peconhento = false;
        }

        public void Botar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Tartaruga_com_ovo;
        }

        public void Chocar(ref PictureBox picAnimal)
        {
            //tartaruga n choca ovo
        }
    }
}