using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Rectangulo : Figura {

        private const string NOMBRE = "rectangulo";

        public Rectangulo(int b, int a) : base(b, a, NOMBRE) {
        }

        public override int perimetro()
        {
            return ((getBase()*2) + (getAlto()*2));
        }

        public override int superficie()
        {
            return (getBase() * getAlto());
        }

    }
}
