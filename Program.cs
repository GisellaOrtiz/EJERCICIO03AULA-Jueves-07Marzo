using practica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO03AULA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CREADO POR : Ortiz Terezon, Gisella Margarita");
            int num;
            Console.WriteLine("DIGITE UNA OPCION");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1: ejercicio1 obj1 = new ejercicio1();
                    Console.WriteLine("DIGITE UN COLOR PARA LA LUZ DEL SEMAFORO");
                    String opcion = Console.ReadLine();
                    Console.WriteLine(obj1.Estados(opcion));
                    Console.ReadKey();
                break;

                case 2:
                    ejercicio2 obj2 = new ejercicio2();
                    String nombre1 = "MARIA";
                    String nombre2 = "ROBERTO";
                    String nombre3 = "DANIEL";
                    String nombre4 = "ROCIO";
                    Console.WriteLine("DIGITE UN COLOR PARA LA LUZ DEL SEMAFORO");
                    String color2 = Console.ReadLine();
                    Console.WriteLine(obj2.Estados(color2, nombre1));
                    Console.WriteLine(obj2.Estados(color2, nombre2));
                    Console.WriteLine(obj2.Estados(color2, nombre3));
                    Console.WriteLine(obj2.Estados(color2, nombre4));
                    Console.ReadKey();
                    break;
                case 3: ejercicio3 obj3 = new ejercicio3();

                    break;
                    
            }
           

        }
    }
}
