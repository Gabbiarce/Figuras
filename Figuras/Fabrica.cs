using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Fabrica
    {
        private ArrayList listaFiguras;
        public Fabrica() { 

            listaFiguras = new ArrayList();
            agregarFiguras();

        }

        private void agregarFiguras()
        {

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int numero = rnd.Next(1, 5);
                
                Random valor = new Random();
                int baseFigura = valor.Next(1, 100);
                int altoFigura = valor.Next(1, 100);

                if (numero == 1)
                {
                    listaFiguras.Add(new Cuadrado(baseFigura));
                }
                if (numero == 2)
                {
                    listaFiguras.Add(new Triangulo(altoFigura, baseFigura));
                }
                if (numero == 3)
                {
                    listaFiguras.Add(new Rectangulo(altoFigura, baseFigura));
                }
                if (numero == 4)
                {
                    listaFiguras.Add(new Circulo(baseFigura));
                }
            }
        }

        public void mostrarFiguras() {
            foreach (Figura figura in listaFiguras)
            {
                Console.WriteLine("El perimetro del " + figura.getNombre() + " es: " + figura.perimetro());
                Console.WriteLine("La superficie del " + figura.getNombre() + " es: " + figura.superficie());
                Console.WriteLine("---------------------------");
            }
        }
            
    }
}
