using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus_Programacion_Basica
{
    internal sealed class Rectangulo : Forma
    {
        private string NombreRectangulo;
        private int area;
        private int perimetro;
        public Rectangulo(string nombreRectangulo, int baseForma, int alturaForma)
        {
            this.NombreRectangulo = nombreRectangulo;
            this.BaseForma = baseForma;
            this.AlturaForma = alturaForma;
            this.LadosForma = new int[] { this.BaseForma, this.BaseForma, this.AlturaForma, this.AlturaForma};
        }
        protected override int CalcularArea()
        {
            this.area = (this.BaseForma * this.AlturaForma);
            return area;
        }

        protected override int CalcularPerimetro()
        {
            this.perimetro = (this.LadosForma[0] + this.LadosForma[1] + this.LadosForma[2] + this.LadosForma[3]);
            return perimetro;
        }

        public string GetNombreRectangulo() { return this.NombreRectangulo; }

        public int GetAreaRectangulo()
        {
            return CalcularArea();
        }

        public int GetPerimetroRectangulo()
        {
            return CalcularPerimetro();
        }
    }
}
