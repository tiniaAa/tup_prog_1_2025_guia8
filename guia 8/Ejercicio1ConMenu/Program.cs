namespace Ejercicio1ConMenu
{
    internal class Program
    {

        static int acumulado;
        static int contador;
        static int maximo;
        static int minimo;


        static void MostrarIniciarVariables()
        {
            Console.Clear();
            Console.WriteLine("Reiniciando variables ");
            acumulado = 0;
            contador = 0;
            maximo = 0;
            minimo = 0; 
            Console.WriteLine("Presione una tecla para continuar ");
            Console.ReadKey();
        }

        static int MostrarPantallaSolicitarOpcioneMenu ()
        {
            Console.Clear ();
            Console.WriteLine("1=Procesar un solo número");
            Console.WriteLine("2=Procesar varios números ");
            Console.WriteLine("3=Mostrar maximo y minimo");
            Console.WriteLine("4=Mostrar promedio");
            Console.WriteLine("5=Mostrar cantidad de numero ingresados");
            Console.WriteLine("6=Reiniciar variables");
            Console.WriteLine("(otro)=salir ");
            int opcion =Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        static void MostrarPantallaSolicitarNumero  ()
        {
            Console.Clear ();
            Console.WriteLine("Ingrese un numero ");
            int valor = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(valor);
        }

        static void RegistrarValor( int valor)
        {
            acumulado = acumulado + valor;
            contador++;
            if (contador==1 || valor < minimo)
            {
                minimo = valor; 
            }
            if (contador==1 || valor > maximo) 
            {
                maximo = valor;
            }
        }

        static void MostrarPantallaSolicitarVariosNumeros() 
        {
            Console.Clear ();
            Console.WriteLine("Ingrese cuantos numeros va a ingresar ");
            int numeros = Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<=numeros;i++)
            {
                MostrarPantallaSolicitarNumero();
            }
        }
        static void MostrarPantallaMaximoYMinimo() 
        {
            Console.Clear();
             
                Console.WriteLine($"El maximo es {maximo} y el minimo es {minimo}");
                Console.WriteLine("Presione una tecla para volver al menu ");
                Console.ReadKey();
            
        }

        static double CalcularPromedio()
        {
            double prom = 0;
            if (contador > 0) { prom = 1.0* acumulado / contador; }
            return prom;
        }
        static void CalcularYMostrarPromedio()
        {
            /*Console.Clear ();
            double prom= CalcularPromedio();
            Console.WriteLine($"El promedio es {prom}");*/

            Console.Clear();
            Console.WriteLine("Pnatalla de promedio ");

            if (contador > 0)
            {
                double prom = CalcularPromedio();
                Console.WriteLine($"Promedio : {prom}");
            }
            else { Console.WriteLine("Promedio: No se han ingresado numeros "); }
            Console.WriteLine("Presione una tecla para volver al menu ");
            Console.ReadKey();
        }
        static void MostrarPantallaCantidad() 
        {
            Console.Clear();
            Console.WriteLine("Pantalla de cantidad de procesados ");

            if (contador !=0)
            {
                Console.WriteLine($"Se procesaron {contador} numeros ");
            }
            else { Console.WriteLine("No se han ingresado numeros "); }
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            
           MostrarIniciarVariables();
            int opcion = MostrarPantallaSolicitarOpcioneMenu();
            
            while (opcion != -1)
            {
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantallaMaximoYMinimo();
                        break;
                    case 4:
                        CalcularYMostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        MostrarIniciarVariables();
                        break;
                    default:
                        opcion = -1;
                        break;
                }
                if (opcion != -1)
                {
                    opcion=MostrarPantallaSolicitarOpcioneMenu();
                }
            }


        }
    }
}
