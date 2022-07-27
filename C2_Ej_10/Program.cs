using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ej_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el dia de la semana: ");
            string dia = Console.ReadLine(); //leemos y asignamos a dia el dia de la semana

            //comprobamos que lo introducido es un dia de la semana          
            if (dia == "lunes" | dia == "Lunes" | dia == "martes" | dia == "Martes" | dia == "miercoles" | dia == "Miercoles" | dia == "jueves" | dia == "Jueves" | dia == "viernes" | dia == "Viernes" | dia == "sabado" | dia == "Sabado" | dia == "domingo" | dia == "Domingo")
            {
                if (dia == "Sabado" | dia == "sabado" | dia == "Domingo" | dia == "domingo") //comprobamos si el dia es sabado o domingo
                {
                    Console.WriteLine();
                    Console.WriteLine("El dia introducido es fin de semana.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("El dia introducido no es fin de semana.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El dia introducido no es un dia de la semana.");
            }
        }
    }
}