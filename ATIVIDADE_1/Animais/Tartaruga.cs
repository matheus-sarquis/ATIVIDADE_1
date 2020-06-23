using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Botar() { }
        public void Chocar() { }
    }
}