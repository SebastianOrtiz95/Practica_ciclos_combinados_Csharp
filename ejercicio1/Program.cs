using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 10 grupos de números enteros separados entre ellos
            //por ceros.Se pide determinar e informar:
            // a.El número de grupo con mayor porcentaje de números impares
            //positivos respecto al total de números que forman el grupo.
            // b.Para cada grupo, el último número primo y en qué orden apareció en
            //ese grupo. Si en un grupo no hubiera números primos, informarlo con
            //un cartel aclaratorio.
            // c.Informar cuántos grupos están formados por todos números ordenados
            //de mayor a menor.


            //int n1,maxPorcentajeImpares=0,posMax=0;
            //Console.WriteLine("ingrese un numero");
            //for (int x = 0; x < 4; x++)
            //{
            //    n1 = int.Parse(Console.ReadLine());

            //    int contTotal = 0, porcentajeImpares = 0, contImpares = 0;
            //    while (n1 != 0)
            //    {
            //        contTotal++;
            //        if (n1 > 0 && n1 % 2 != 0)
            //        {
            //          contImpares++;
            //        }

            //        n1 = int.Parse(Console.ReadLine());
            //    }
            //    porcentajeImpares = (contImpares * 100) / contTotal;
            //    if (porcentajeImpares > maxPorcentajeImpares)
            //    {

            //        maxPorcentajeImpares = porcentajeImpares;
            //        posMax = x + 1;

            //    }






            //}
            //Console.WriteLine("el grupo con mas porcentaje de impares fue el: " + posMax);
            //Console.ReadKey();  
            //int n1;

            //Console.WriteLine("ingrese un numero");
            //for (int x = 0; x < 4; x++)
            //{
            //    n1 = int.Parse(Console.ReadLine());
            //    int primo=0,z=0,pos=0;
            //    while (n1!=0)
            //    {
            //        int cont = 0;
            //        z++;
            //        for (int  y= 1; y <=n1; y++)
            //        {
            //            if (n1%y==0)
            //            {
            //                cont++;
            //            }
            //        }
            //        if (cont==2)
            //        {
            //            primo = n1;
            //            pos = z;
            //        }
            //        n1 = int.Parse(Console.ReadLine());
            //     }
            //    if (primo != 0)
            //    {
            //        Console.WriteLine("el ultimo numero primo fue el {0} ingresado en el {1}° lugar",primo,pos);
            //    }
            //    else
            //    {
            //        Console.WriteLine("no hay numeros primos en este grupo");
            //    }
            //}

            int n1,men=0,grupoOrdenado=0;
            Console.WriteLine("ingrese un numero");
            for (int x = 0; x < 4; x++)
            {
                
                n1 = int.Parse(Console.ReadLine());
                bool banMen = false;
                bool orden = true;  
                while (n1!=0)
                {
                    if (banMen==false)
                    {
                        men = n1;
                        banMen = true;
                    }
                    else
                    {
                        if (n1<men)
                        {
                            men = n1;
                        }
                        else
                        {
                            orden = false;
                        }
                    }
                    n1 = int.Parse(Console.ReadLine());
                }
                if (orden==true)
                {
                    grupoOrdenado++;
                }

            }
            Console.WriteLine("los grupos ordenados de mayor a menor son : " + grupoOrdenado);

            Console.ReadKey();

        }

        
    }
}
