using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Cuadrado : Figura
    {
        private const string NOMBRE = "cuadrado";

        public Cuadrado(int lado) : base(lado, lado, NOMBRE) {
        }
        
        public override int perimetro(){
            return (getBase() * 4);
        }

        public override int superficie()
        {
            return (getBase() * getAlto());
        }

    }
}
