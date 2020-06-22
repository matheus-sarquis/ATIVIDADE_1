using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    public interface IVoar
    {
        void Voar();
        int altitudeMax { get; set; }
        double velocidadeVoo { get; set; }
    }
}