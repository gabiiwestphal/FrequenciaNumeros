using System;
using System.Collections.Generic;

namespace FrequenciaNumerosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 8, 10, 8, 260, 4, 10, 10 };

            Array.Sort(array);

            int i = 0;
            int j = 0;

            while (i < array.Length)
            {
                int numero = array[i];
                int quantidadeVezes = 0;

                while (array[i] == array[j])
                {
                    quantidadeVezes++;
                    j++;

                    if (j == array.Length) 
                        break;
                }

                string sufixo = (quantidadeVezes > 1) ? " vezes" : " vez";

                Console.WriteLine(numero + " apareceu " + quantidadeVezes + sufixo);

                i = j;
            }          

            Console.ReadLine();

        }
    }
}
