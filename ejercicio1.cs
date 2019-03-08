using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public class ejercicio1
    {

        
        public String Estados(String opcion)
        {
            if (opcion == "verde")
                return "ADELANTE";
            else if (opcion == "amarillo")
                return "PRECAUCION";
            else if (opcion == "rojo")
                return "ALTO";
            else return "INGRESE UNA OPCION VALIDA";


        }
    }

   
}
