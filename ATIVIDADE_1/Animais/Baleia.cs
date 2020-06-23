using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Baleia : Mamifero, IAquatico
    {
        #region Variáveis
        private bool viveEmT;
        private bool mergulho;
        private bool aguaDoce;

        public bool ViveEmT { get => viveEmT; set => viveEmT = value; }
        public bool Mergulho { get => mergulho; set => mergulho = value; }
        public bool AguaDoce { get => aguaDoce; set => aguaDoce = value; }
        #endregion

        public Baleia(string nome, DateTime nasc, char sexo, int idade)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;
            Idade = idade;

            Carnivoro = true;
            Peconhento = false;
            ViveEmT = false;
            Mergulho = true;
            AguaDoce = false;
        }        
    }
}