namespace Encuestados
{
    internal class Program
    {
        static int indeciso,negativos,positivos;
        static double por_indeciso, por_negativos, por_positivos;
        
        
        
         
        static void RegistrarOp (int op)
        {
            switch (op) 
            {
                case 0:
                    positivos++;
                    break;
                case 1:
                    negativos++;
                    break;
                case 2:
                    indeciso++;
                    break;
            }
        }



        static void MostrarPantallaRegistrarOp()
        {
            Console.Clear();
            int res;
            res = 1;
            while(res==1)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(@$"0=positivo 
1=negativo
2=indeciso");
                    Console.Write("respuesta: ");
                    res = Convert.ToInt32(Console.ReadLine());

                } while (res != 0 && res != 1 && res != 2);

                RegistrarOp(res);
                Console.Clear();
                Console.WriteLine("Desea ingresar otra opiinion? \n1=si\n2=no");
                res = Convert.ToInt32(Console.ReadLine());
            }


        }

        static void procesarEncuesta()
        {

            double tot = indeciso + positivos + negativos;


            if (tot > 0)
            {
             
                por_indeciso = 100.0*indeciso/tot;
                por_negativos=100.0*negativos/tot;
                por_positivos=100.0*positivos/tot;
            }
        }
        static void MostrarPantallResultados()
        {
            Console.Clear();
            procesarEncuesta();
            int tot =(indeciso+positivos+negativos);
            Console.WriteLine($"Se encuesto un total de {tot} personas");
            Console.WriteLine($"positivos:  %{por_positivos:f2}");
            Console.WriteLine($"negativos:  %{por_negativos:f2}");
            Console.WriteLine($"indecisos:  %{por_indeciso:f2}\n\n\n");

            Console.Write("Presione una tecla para continuar");
            Console.ReadKey();

        }
        static int MostrarPantallaMenu()
        {
            Console.Clear();
            Console.WriteLine(@$"1=Registrar opinión 
2=Procesar y mostrar resultados de la encuesta
(otro)=salir");
            int res = Convert.ToInt32(Console.ReadLine());
            return res;
        }

        static void Main(string[] args)
        {
            int res = MostrarPantallaMenu();

            while (res != -1) 
            {
                switch (res)
                {
                    case 1:
                        MostrarPantallaRegistrarOp();
                        break;
                    case 2:
                        MostrarPantallResultados();
                        break;
                    default:
                        if (res != -1)
                        {
                            res = -1;
                        }
                        break;

                }

                if (res != -1)
                    res= MostrarPantallaMenu();
            }


        }
    }
}
