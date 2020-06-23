using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Reptil : Animal
    {
        #region Variáveis
        private bool escamas;
        private bool casco;

        public bool Escamas { get => escamas; set => escamas = value; }
        public bool Casco { get => casco; set => casco = value; }
        #endregion
    }
}