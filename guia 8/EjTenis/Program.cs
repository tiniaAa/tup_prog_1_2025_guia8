using System.Security;

namespace EjTenis
{
    internal class Program
    {

         static string jugador1, jugador2;
         static int set_Ganados1, set_Ganados2;

         static int Mostrar_menu()
         {
             Console.Clear();
             Console.WriteLine("MENU\n\n");
             Console.WriteLine("1=Registrar nombres de los jugadores ");
             Console.WriteLine("2=Registrar los resultados se sets");
             Console.WriteLine("3=Mostrar ganador ");
             Console.WriteLine("otro=salir");
             int op = Convert.ToInt32(Console.ReadLine());
             return op;
         }
         static void Solicitar_Nombres()
         {
             Console.Clear();
             Console.WriteLine("Ingrese el nombre del jugador 1");
             string nombre1 = Console.ReadLine();
             Console.WriteLine("\n\nIngrese el nombre del jugador 2");
             string nombre2 = Console.ReadLine();
             Registrar_Nombre(nombre1, nombre2);
             Console.WriteLine("\nPresione una tecla para continuar ");
             Console.ReadKey();

         }
         static void Registrar_Nombre(string nombre1,string nombre2)
         {
             jugador1 = nombre1;
             jugador2 = nombre2;
         }
         static void Solicitar_Res()
         {
             Console.Clear();

             Console.WriteLine("Registro de sets\n\n");
             Console.WriteLine("Ingrese los sets de cada jugador ");
             for (int i=1;i<=3;i++)
             {
                 Console.WriteLine($"Set {i}");
                Console.Write($"Resulltado {jugador1}:");
                int res=Convert.ToInt32(Console.ReadLine());
                Console.Write($"Resultado {jugador2}");
                int res2=Convert.ToInt32(Console.ReadLine());
                Registrar_Resultados(res,res2);
             }
         }
        static void Registrar_Resultados(int res, int res2)
        {
            set_Ganados1 = set_Ganados1 + res;
            set_Ganados2=set_Ganados2 + res2;
        }
        static void  Mostrar_Ganador ()
        {
            string gana = Determinar_Ganador();
            Console.WriteLine($"El ganador es {gana}\n\n");
            Console.WriteLine("Presione una tecla para continuar ");
            Console.ReadKey();
        }
        static string Determinar_Ganador ()
        {
            if (set_Ganados1>set_Ganados2)
            {
                return jugador1;
            }
            else if (set_Ganados1<set_Ganados2)
            {
                return jugador2;
            }
            else { return "No hay ganador "; }
        }


        static void Main(string[] args)
        {

            int op = Mostrar_menu();

            while (op != -1) 
            {
                switch (op)
                {
                    case 1:
                        Solicitar_Nombres();
                        break;
                    case 2:
                        Solicitar_Res();
                        break;

                    case 3:
                        Mostrar_Ganador();
                        break;
                    default:
                        op = -1;
                        break;

                }
                if (op != -1)
                {
                    op = Mostrar_menu();
                }
            }



        }
    }
}
