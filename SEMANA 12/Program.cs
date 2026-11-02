using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_12
{
    internal class Program
    {
        public static void factorial_sinrecursividad()
        {
            Console.WriteLine("Ingresar numero: ");
            int N=int.Parse(Console.ReadLine());
            long F = 1;
            for (int i = 1; i <= N; i++)
            {
                F = F * i;
            }
            Console.WriteLine("factorial: "+F);
        }
        public static long factorial_conrecursividad(int N)
        {
            if (N==0 || N == 1)
            {
                return 1;
            }
            return N * factorial_conrecursividad(N - 1);
        }
        public static void potencia_sinrecursividad()
        {
            int B, expo;
            Console.WriteLine("Ingresar base: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar exponente: ");
            expo= int.Parse(Console.ReadLine());
            long P = 1;
            for(int i = 1;i <= expo; i++)
            {
                P = P * B;
            }
            Console.WriteLine("Potencia: " + P);
        }
        static public double potencia_conrecursividad(int B, int expo)
        {
            if (expo==0)
            {
                return 1;
            }
            return B * potencia_conrecursividad(B, expo);
        } 
        static public int sumatoria (int N)
        {
            if (N == 0)
            {
                return 1;
            }
            return N*sumatoria(N-1);
        }
        //Conteo regresivo
        static public int conteo_regresivo(int N)
        {
            if (N==0)
            {
                return 0;
            }
            Console.WriteLine(N);
            return conteo_regresivo(N-1);
        }
        static public int suma_arreglo(int[]numeros, int indice)
        {
            if(indice>=numeros.Length)
            {
                return 0;
            }
            return numeros[indice]+suma_arreglo(numeros, indice+1);
        }
        static void Main(string[] args)
        {
            int opc;
            bool S=true;
            while (S)
            {
                Console.Clear();
                Console.WriteLine("*******************************************");
                Console.WriteLine("\t\tMenu de opciones");
                Console.WriteLine("[1] Factorial sin recursividad");
                Console.WriteLine("[2] Factorial con recursividad");
                Console.WriteLine("[3] Potencia sin recursividad");
                Console.WriteLine("[4] Potencia con recursividad");
                Console.WriteLine("[5] Sumatoria de N primeros numeros naturales");
                Console.WriteLine("[6] Conteo regresivo N a 1");
                Console.WriteLine("[7] Arreglos");
                Console.WriteLine("[8] Salida");
                Console.WriteLine("*******************************************");
                Console.Write("Ingresar una opcion: ");
                opc=int.Parse(Console.ReadLine());
                switch(opc)
                {
                    case 1:
                        factorial_sinrecursividad();
                        break;
                    case 2:
                        Console.Write("Ingresar numero:");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine(N + "!=" + factorial_conrecursividad(N));
                        break;
                    case 3:
                        potencia_sinrecursividad();
                        break;
                    case 4:
                        Console.Write("Ingrese la base");
                        int B = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el exponente");
                        int expo = int.Parse(Console.ReadLine());
                        Console.WriteLine(B + "^" + expo + "=" + potencia_conrecursividad(B, expo));
                        break;
                    case 5:
                        Console.Write("Ingresar el numero de N:");
                        int N1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sumatoria de numeros naturales: es:" + sumatoria(N1));
                        break;
                    case 6:
                        Console.Write("Ingresar el valor de N:");
                        int N2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Conteo regresivo de N a 1:" + conteo_regresivo(N2));
                        break;
                    case 7:
                        Console.WriteLine("****************************");
                        Console.WriteLine("\tSUMA DE ARREGLOS");
                        Console.WriteLine("****************************");
                        int[] numeros = { 10, 20, 30, 40, 50 };
                        Console.WriteLine("Suma de arreglo: " + suma_arreglo(numeros, 0));
                        break;
                    case 8:
                        S = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.ReadKey();
            }
            
        }
    }
}
