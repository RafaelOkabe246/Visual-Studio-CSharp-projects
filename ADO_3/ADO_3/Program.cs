using System;

namespace ADO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[10];
            //float maiorNumero = 0, segundoMaior = 0, terceiroMaior = 0;
            float[] tresMaioresNumeros = new float[3];

            //Define the values
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = float.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);

            //Exibir todos
            /*
            foreach (float numero in numeros)
            {
                Console.WriteLine("Número: " + numero);
            }
            */

            //Exibir os três maiores em ordem decrescente
            Console.WriteLine("Os três maiores números, do maior para o menor");
            for (int i = numeros.Length; i > numeros.Length - 3; i--)
            {
                Console.WriteLine(numeros[i-1]);//numeros[i] );
            }

            Console.WriteLine("");
            Console.WriteLine("Sinceramente, essa ADO tá mais difícil que a prova.");
            /*
            Console.WriteLine("Maior número: " + maiorNumero);
            Console.WriteLine("Segundo maior número: " + segundoMaior);
            Console.WriteLine("Terceiro maior número: " + terceiroMaior);
            */
            Console.ReadLine();
        }
    }
}
