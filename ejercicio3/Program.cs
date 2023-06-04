using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar los valores de los pesos de distintas
            //encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
            //ingresa un peso negativo.Se deben agrupar las encomiendas en camiones que
            //pueden transportar hasta 200 kilos en total.
            // Por ejemplo:
            // 10, 20, 140, 70, 100, 40, 10, 50, 80, 90, 30, 40, 50, -10.
            // Camión 1.Camión 2 Camión 3 Camión 4 Camión 5
            //Se pide determinar e informar:
            // a.El número de camión y peso total de encomiendas(Camión 1: 170kg,
            //Camión 2: 170kg, etc.).
            // b.El número de camión que transporta mayor cantidad de encomiendas
            //(en el ejemplo anterior sería el camión 3 con 4 encomiendas).
            // c.La cantidad de camiones que se terminaron cargando.

            double pesoEncomienda;
            int nroCamion,camionMax=0, camion=0, camionMaxEncomiendas=0;
            Console.WriteLine("ingrese el peso de la encomienda: ");
            pesoEncomienda=double.Parse(Console.ReadLine());
            while (pesoEncomienda>0)
            {
                Console.WriteLine("");
                Console.WriteLine("ingrese nro camion: ");
                nroCamion=int.Parse(Console.ReadLine());
                camion++;
                double pesoTotal = 0;
                int contEncomiendas = 0;
                while (pesoEncomienda + pesoTotal <=200 && pesoEncomienda>0 )
                {
                    
                    pesoTotal += pesoEncomienda;
                    contEncomiendas++;
                    
                    Console.WriteLine("ingrese peso encomienda");
                    pesoEncomienda = double.Parse(Console.ReadLine());  
                }
                Console.WriteLine("camion: " + nroCamion);
                Console.WriteLine("peso total encomiendas: {0}KG",pesoTotal);
                if (contEncomiendas>camionMax)
                {
                    camionMax = contEncomiendas;
                    camionMaxEncomiendas = nroCamion;
                }

            }
            Console.WriteLine("");
            Console.WriteLine("el camion con mas encomiendas fue el camion: " + camionMaxEncomiendas);
            Console.WriteLine("la cantidad de camiones cargados fueron: " + camion );
            Console.ReadKey();
        }
    }
}
