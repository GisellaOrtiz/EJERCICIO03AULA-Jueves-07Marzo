using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
   public class ejercicio2
    {
        public String Estados(String opcion, String nombre)
        {
            if (opcion == "verde")
                return "ADELANTE"+" "+nombre;
            else if (opcion == "amarillo")
                return "PRECAUCION"+" "+ nombre;
            else if (opcion == "rojo")
                return "ALTO"+" "+nombre;
            else return "INGRESE UNA OPCION VALIDA";


        }

    }
}
