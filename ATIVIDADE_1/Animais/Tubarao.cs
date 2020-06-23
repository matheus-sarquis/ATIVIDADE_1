using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Tubarao : Animal, IOviparo, IAquatico
    {
        #region Variáveis
        private bool viveEmT;
        private bool mergulho;
        private bool aguaDoce;

        public bool ViveEmT { get => viveEmT; set => viveEmT = value; }
        public bool Mergulho { get => mergulho; set => mergulho = value; }
        public bool AguaDoce { get => aguaDoce; set => aguaDoce = value; }
        #endregion

        public void Botar() { }
        public void Chocar() { }

        public Tubarao(string nome, DateTime nasc, int idade, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Idade = idade;
            Sexo = sexo;

            ViveEmT = false;
            Mergulho = true;
            AguaDoce = false;
            Carnivoro = true;
            Peconhento = false;
        }
    }
}
