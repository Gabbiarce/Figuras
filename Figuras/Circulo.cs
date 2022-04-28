using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Circulo : Figura
    {
        private const string NOMBRE = "circulo";
        private double pi;

        public Circulo(int radio) : base(radio, radio, NOMBRE){
            this.pi = 3.1415;
        }

        public override int perimetro()
        {
            return (int)(getBase() * 2 * this.pi);
        }

        public override int superficie()
        {
            return (int)((getBase() * getBase()) * this.pi);
        }

    }
}
