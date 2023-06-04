using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una compañía de electricidad necesita calcular anualmente el consumo que ha
            //registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos.
            //Para ello tiene un lote de registros por cada uno de los usuarios con los
            //siguientes datos:
            // • Zona(numérico entero).
            // • Número de cliente(número de cuatro dígitos no correlativos).
            // • Cantidad de kilovatios consumidos en el periodo.
            //El lote se encuentra agrupado(no ordenado) por zona y finaliza con un registro
            //con zona igual a cero.
            //Se pide generar un listado con el siguiente formato:
            //   Zona: XX
            //   Cantidad de usuarios de la zona: XX
            //   Total facturado en la zona: XX
            //   Zona: XX
            //   Cantidad de usuarios de la zona: XX
            //   Total facturado en la zona: XX
            //El precio es escalonado según la siguiente escala:
            // • $ 0.10 por kv por los primeros 100 kv de consumo.
            // • $ 0.12 por kv por el consumo de 101 a 200 kvs.
            // • $ 0.15 por kv por el consumo de 201 kvs en adelante.

            int zona,zonaActual,numCliente,KilovatiosConsumidos;
            Console.WriteLine("ingrese la zona: ");
            zona = int.Parse(Console.ReadLine());
            while (zona!=0)
            {
                zonaActual = zona;
                int contClientes = 0;
                double  precioFinal=0,totalFacturado=0;
                while (zonaActual==zona)
                {
                    Console.WriteLine("numero de cliente: ");
                    numCliente = int.Parse(Console.ReadLine());
                    contClientes++;
                    Console.WriteLine("kilovatios consumidos: ");
                    KilovatiosConsumidos = int.Parse(Console.ReadLine());
                    if (KilovatiosConsumidos>201)
                    {
                        precioFinal = KilovatiosConsumidos * 0.15;
                    }
                    else
                    {
                        if (KilovatiosConsumidos>100 && KilovatiosConsumidos<201)
                        {
                            precioFinal = KilovatiosConsumidos * 0.12;
                        }
                        else
                        {
                            precioFinal = KilovatiosConsumidos * 0.10;
                        }
                    }
                    totalFacturado += precioFinal;
                    Console.WriteLine("ingrese zona: ");
                    zona= int.Parse(Console.ReadLine());    
                }
                
                Console.WriteLine("zona : " + zonaActual);
                Console.WriteLine("Cantidad de usuarios de la zona: " + contClientes);
                Console.WriteLine("Total facturado en la zona USD {0} ",totalFacturado);
            }
            Console.ReadLine();
        }
    }
}
