using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus_Programacion_Basica
{
    internal abstract class Forma
    {

        protected int BaseForma { get; set; }
        protected int AlturaForma { get; set; }
        protected int[] LadosForma { get; set; }
   
        protected abstract int CalcularArea();
        protected abstract int CalcularPerimetro();
    }
}
