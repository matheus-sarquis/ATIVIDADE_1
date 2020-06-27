using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    public interface IOviparo
    {
        void Botar(ref PictureBox picAnimal);
        void Chocar(ref PictureBox picAnimal);
    }
}