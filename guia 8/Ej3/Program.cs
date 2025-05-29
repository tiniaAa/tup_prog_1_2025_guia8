
namespace Ej3
{
    internal class Program
    {

        static string nombre0,nombre1,nombre2;
        static int numeroLibreta0,numeroLibreta1,numeroLibreta2,orde;

        static int MostrarPantallaMenu()
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1=Registrar las notas de los tres alumnos");
            Console.WriteLine("2=Mostrar lista ordenada");
            Console.WriteLine("-1=salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void SolicictarAlumnos() 
        {
            Console.Clear();
            Console.WriteLine("Ingreso de alumnos ");

            for (int i=1; i <= 3; i++)
            {
                
                Console.WriteLine($"Ingrese el nombre del alumno {i}");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese la nota de la libreta de {nombre}");
                int nota = Convert.ToInt32(Console.ReadLine());
                Registrar_nombre_numerolib(nombre, nota, i);
            }
        }
        static void Registrar_nombre_numerolib (string nombre, int nota, int i )
        {
            switch (i)
            {
                case 1:
                    nombre0= nombre;
                    numeroLibreta0 = nota;
                    break;
                case 2:
                    nombre1 = nombre;
                    numeroLibreta1 = nota;
                    break;
                case 3:
                    nombre2 = nombre;
                    numeroLibreta2 = nota;
                    break;
            }
        }
        static void Mostrar_Lista_Ordenada()
        {
                Console.Clear();

                if (numeroLibreta0 > numeroLibreta1 && numeroLibreta1 > numeroLibreta2)
                {
                    Console.WriteLine($"{nombre0} {numeroLibreta0}");
                    Console.WriteLine($"{nombre1} {numeroLibreta1}");
                    Console.WriteLine($"{nombre2} {numeroLibreta2}");
                }
                else if (numeroLibreta0 > numeroLibreta2 && numeroLibreta2 > numeroLibreta1)
                {
                    Console.WriteLine($"{nombre0} {numeroLibreta0}");
                    Console.WriteLine($"{nombre2} {numeroLibreta2}");
                    Console.WriteLine($"{nombre1} {numeroLibreta1}");
                }
                else if (numeroLibreta1 > numeroLibreta0 && numeroLibreta0 > numeroLibreta2)
                {
                    Console.WriteLine($"{nombre1} {numeroLibreta1}");
                    Console.WriteLine($"{nombre0} {numeroLibreta0}");
                    Console.WriteLine($"{nombre2} {numeroLibreta2}");
                }
                else if (numeroLibreta1 > numeroLibreta2 && numeroLibreta2 > numeroLibreta0)
                {
                    Console.WriteLine($"{nombre1} {numeroLibreta1}");
                    Console.WriteLine($"{nombre2} {numeroLibreta2}");
                    Console.WriteLine($"{nombre0} {numeroLibreta0}");
                }
                else if (numeroLibreta2 > numeroLibreta0 && numeroLibreta0 > numeroLibreta1)
                {
                    Console.WriteLine($"{nombre2} {numeroLibreta2}");
                    Console.WriteLine($"{nombre0} {numeroLibreta0}");
                    Console.WriteLine($"{nombre1} {numeroLibreta1}");
                }
                else if (numeroLibreta2 > numeroLibreta1 && numeroLibreta1 > numeroLibreta0)
                {
                    Console.WriteLine($"{nombre2} {numeroLibreta2}");
                    Console.WriteLine($"{nombre1} {numeroLibreta1}");
                    Console.WriteLine($"{nombre0} {numeroLibreta0}");
                }
                else
                {
                    Console.WriteLine("Hay alumnos con la misma nota. Orden no definido.");
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.ReadKey();
            





            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int op = MostrarPantallaMenu();
            while (op!=-1)
            {
                switch (op)
                {
                    case 1:
                        SolicictarAlumnos();
                        break;
                    case 2:
                        Mostrar_Lista_Ordenada();
                        break;
                    default:
                        op = -1;
                        break;
                }
                
                op=MostrarPantallaMenu(); 
            }













        }
    }
}


