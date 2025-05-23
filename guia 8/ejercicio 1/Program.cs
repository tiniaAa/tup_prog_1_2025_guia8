using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declarar variables 
            int max_valor, men_valor, acumulador, ingresos, valor;
            double prom;
            #endregion

            #region inicializar
            prom = 0;
            acumulador = 0;
            max_valor = 0;
            men_valor = 0;

            #endregion

            #region solicitar ingresos
            Console.WriteLine("Ingrese la cantidad de ingresos ");
            ingresos = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region iterador para 
            for (int n = 1; n == ingresos; n = n + 1)
            {
                Console.WriteLine("Ingese valor");
                valor = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + valor;

                if (valor > max_valor || n == 1)
                {
                    max_valor = valor;
                }
                if (valor < men_valor || n == 1)
                {
                    men_valor = valor;
                }
                contador++;
            }
            #endregion
            #region calacular promedio
            if (acumulador != 0)
            {
                prom = acumulador / n;
            }
            #endregion

            #region mostrar todo 
            Console.WriteLine($"El numero maximo es {max_valor} el numero menor es {men_valor} y el promedio es {prom}");
            #endregion
        }
    }
}
