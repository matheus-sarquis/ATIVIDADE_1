using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    public interface IVoar
    {
        int AltitudeMax { get; set; }
        double VelocidadeVoo { get; set; }

        void Voar(ref PictureBox picAnimal);        
    }
}