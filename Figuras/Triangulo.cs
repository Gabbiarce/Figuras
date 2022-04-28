using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Triangulo : Figura{

        private const string NOMBRE = "triangulo";

        public Triangulo(int b, int a) : base(b, a, NOMBRE) {
        }

        public override int perimetro()
        {
            return (getBase() + (getAlto() * 2));
        }

        public override int superficie()
        {
            return ((getBase() * getAlto()) / 2);
        }

    }
}
