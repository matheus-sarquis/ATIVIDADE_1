using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    public interface IPredador
    {
        void Atacar(ref PictureBox picAnimal);
    }
}