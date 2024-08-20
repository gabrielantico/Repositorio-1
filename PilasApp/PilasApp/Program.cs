using PilasApp.Clases;
using PilasApp.Interfaces;

namespace PilasApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pila1 = new Pila(10);
            var cola1 = new Cola(10);
            var pila2 = new Pila(10);
            var cola2 = new Cola(10);

            ColleccionAbstracta[] array = {pila1, cola1, pila2, cola2};

            foreach (ColleccionAbstracta c in array) 
            {
                Console.WriteLine(c.Añadir(c));
            }

            foreach (ColleccionAbstracta c in array)
            {
                Console.WriteLine(c.EstaVacia());
            }

            foreach (ColleccionAbstracta c in array)
            {
                Console.WriteLine(c.Extraer());
            }

        }
    }
}