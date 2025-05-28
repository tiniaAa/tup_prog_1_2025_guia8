namespace Ejercicio2
{
    internal class Program
    {
        static int edad0;
        static int edad1;
        static int edad2;
        static int edad3;

        static double monto;
        static double porcentaje0;
        static double porcentaje1;
        static double porcentaje2;
        static double porcentaje3;
        static double monto0;
        static double monto1;
        static double monto2;
        static double monto3;

        static int MostrarPantallasSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1=Iniciar monto a repartir");
            Console.WriteLine("2=Solicitar Edad Por niña");
            Console.WriteLine("3=Mostrar monto y porcentajes que corresponde a cada niña");
            Console.WriteLine("otro=salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaSolicictarMontoAReptaritr() 
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a repartir ");
            double mont = Convert.ToDouble(Console.ReadLine());
            RegistrarMontoARepartir(mont);
        }
        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            Console.Clear();
            CalcularMontosYPorcentajesARepartir();
            Console.WriteLine($"El porcentaje que le toca a la niña 1 es %{porcentaje0} y recibe {monto0}");
            Console.WriteLine($"El porcentaje que le toca a la niña 2 es %{porcentaje1} y recibe {monto1}");
            Console.WriteLine($"El porcentaje que le toca a la niña 3 es %{porcentaje2} y recibe {monto2}");
            Console.WriteLine($"El porcentaje que le toca a la niña 4 es %{porcentaje3} y recibe {monto3}");
            Console.ReadKey();
        }
        static void RegistrarMontoARepartir( double mont)
        {
            monto =mont;

        } 



        static void MostrarPantallaSolicitarEdadesNiñas() 
        {
            Console.Clear();
            Console.WriteLine("Edades de las niñas");

            for (int i=1;i<=4;i++)
            {
                Console.WriteLine($"Ingrese la edad de la niña {i}");
                int edad = Convert.ToInt32(Console.ReadLine());
                RegistrarEdad(edad,i);
            }
        }
        static void RegistrarEdad(int edad, int i) 
        {
            switch (i)
            {
                case 1:
                    edad0 = edad;
                    break;
                case 2:
                    edad1 = edad;
                    break;
                case 3:
                    edad2 = edad;
                    break;
                case 4:
                    edad3 = edad;
                    break;
            }
        }

        static void CalcularMontosYPorcentajesARepartir()
        {
            double edadTot = edad0 + edad1 + edad2 + edad3;
            porcentaje0= (1.0 * edad0 / edadTot) * 100;
            porcentaje1= (1.0 * edad1 / edadTot) * 100;
            porcentaje2= (1.0 * edad2 / edadTot) * 100;
            porcentaje3= (1.0 * edad3 / edadTot) * 100;

            monto0 = monto * porcentaje0 / 100;
            monto1 = monto * porcentaje1 / 100;
            monto2 = monto * porcentaje2 / 100;
            monto3 = monto * porcentaje3 / 100;
        }


        static void Main(string[] args)
        {
            int op = MostrarPantallasSolicitarOpcionMenu();

            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicictarMontoAReptaritr();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;
                    case 3:
                        MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();
                        break;
                    default:
                        op = -1;
                        break;

                }
                if (op != -1)
                {
                    op = MostrarPantallasSolicitarOpcionMenu();
                }
            }
        }
    }
}
