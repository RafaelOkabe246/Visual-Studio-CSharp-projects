using System;

namespace ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            float[] numeros = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            float somaDosNumeros = 0;

            float numeroMaior = 0;
            float numeroMenor = 0;
            Console.WriteLine("Escreva 10 números positivos ou negativos");
            for (int i = 0; i < 10; i++)
            {
                float n = float.Parse(Console.ReadLine());
                numeros[i] = n;
                somaDosNumeros += n;

                if(numeroMaior == 0 && numeroMenor == 0)
                {
                    numeroMenor = n;
                    numeroMaior = n;
                }
             
                if(numeroMaior < n )
                    numeroMaior = n;

                if(numeroMenor > n)
                    numeroMenor = n;
            }

            Console.WriteLine("Esses são os números que você escreveu");

            Console.WriteLine("Agora veja o resultado da soma desses números: " + somaDosNumeros);
            Console.WriteLine("O maior número é " + numeroMaior + " e o menor número é " + numeroMenor);
            Console.WriteLine("A média é: " + somaDosNumeros/numeros.Length);
            */

            /*
            int numero;

            numero = -20;

            Console.WriteLine(numero);

            if (numero > 200)
            {
                Console.WriteLine("numero é maior que 200");
            }
            
            else if (numero == 200)
            {
                Console.WriteLine("numero igual a 200");
            }
            
            else if (numero < 0)
            {
                Console.WriteLine("numero negativo ");
            }
            
            else
            {
                Console.WriteLine("numero menor que 200");
            }
           */

            
            /*

            string nome;

            nome = "";

            Console.WriteLine("Qual é o seu nome ?");

            nome = Console.ReadLine();

            Console.WriteLine("seu nome é "+nome+ " , prazer!");
           
            */
            string perg;
            int ano;
            int anoAtual = 2022;
            int resultado;
            
            perg = "Que ano voce nasceu ?";

            Console.WriteLine(perg);

            ano = int.Parse(Console.ReadLine());

            resultado = anoAtual - ano;
            Console.WriteLine("Voce tem " + resultado + " anos");

            if (resultado < 0)
            {

                Console.WriteLine("Voce é do futuro!");
            }
            else if (resultado > 200)
            {
                Console.WriteLine("Voce é pré-histoico !");
            }
            
            
            
            
           
            Console.ReadLine();
        }
    }
}
