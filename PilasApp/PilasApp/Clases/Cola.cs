using PilasApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasApp.Clases
{
    public class Cola : ColleccionAbstracta
    {
        public Cola(int size) : base(size)
        {
            
        }

        public override object Extraer()
        {
            object p;
            if (!EstaVacia())
            {
                int i;

                for (i = 0; i < siguiente && coleccion[i] == null; i++) ;

                p = coleccion[i];
                coleccion[i] = null;

                return p;
            }
            else
            {
                return "Está vacía";
            }
        }
    }
}
