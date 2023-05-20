using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int[] numeros = new int[15];
            int x = 0;

            for (x=0; x <=14; x++)
            {
                Console.WriteLine("Digite o " + (x+1) + "º número");
                numeros[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Os números foram:");
            for (x = 14; x >= 0; x--)
            {
                Console.WriteLine(numeros[x]);
            } */



            /* int[] palpite = new int[6];
             int x = 0;

             for (x=0; x <=5; x++)
             { 

                 Console.WriteLine("Digite o " + (x+1) + "° valor");
             palpite[x] = int.Parse (Console.ReadLine());
             }

             Console.WriteLine("Os valores digitados foram:");
             for (x=5; x>=0; x--)
             {
                 Console.WriteLine(palpite[x]);
             }*/

            int[,] cartela = new int[4, 4];

            int[,] cartelaNova =
            {
                { 11, 12, 12, 12 },
                { 15, 55, 12, 12 },
                { 82, 12, 12, 12 },
                { 28, 25, 12, 12 }
            };
            ArrayList jaInseridos = new ArrayList();
            Random rnd = new Random();
            int numero = 0;
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    numero = rnd.Next(17);
                   if(!jaInseridos.Contains(numero))
                    {
                        cartela[i, j] = numero;
                        jaInseridos.Add(numero);

                    }
                   else
                    {
                        j--;
                    }
                    

                }
            }
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.Write(cartela[i,j] + "\t");
                }
            }   Console.WriteLine();


        }

        private static ArrayList newArrayList()
        {
            throw new NotImplementedException();
        }
    }
}
