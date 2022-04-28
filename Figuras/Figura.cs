using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public abstract class Figura
    {
        private int altoFigura;
        private int baseFigura;
        private string NOMBRE;

        public Figura(int altoFigura, int baseFigura, string NOMBRE)
        {
            this.altoFigura = altoFigura;
            this.baseFigura = baseFigura;
            this.NOMBRE = NOMBRE;
        }

        public abstract int perimetro();
        public abstract int superficie();

        public int getAlto() {
            return this.altoFigura;
        }

        public int getBase() {
            return this.baseFigura;
        }

        public string getNombre() {
            return this.NOMBRE;
        }

    }

    
}
