using System;

namespace Exercicios_matematica
{
    class Aulas
    {
        static void Main(string[] args)
        {
            #region Produto_Misto
            Console.WriteLine("Produto misto - serve para calcular o paralelepípedo formado por um vetor");
            Console.WriteLine("Mistura de produto vetorial e escalar");
            LineJump(1);
            Console.WriteLine("[a, b, c] = (a * b) * c");
            LineJump(3);

            Console.WriteLine("Representação visual desse cálculo");
            LineJump(1);

            Console.WriteLine("(a * b) * c = " + "|x¹, x², x³| <--- a");
            Console.WriteLine("              |y¹, y², y³| <--- b");
            Console.WriteLine("              |z¹, z², z³| <--- c");

            LineJump(2);
            Console.WriteLine("Exemplo - Calcule o produto misto entre os vetores u = <2, 1, 2>, v = <0, 3, 3> e w = <1, 0, 1>");
            LineJump(2);

            int[] u = CriarVetor(5, 4, 3);
            int[] v = CriarVetor(0, 3, -2);
            int[] w = CriarVetor(1, 0, 1);

            int resultado = CalculoProdutoMisto(u, v, w);
            //Console.WriteLine(resultado);
            LineJump(3);
            Console.WriteLine(CalculoProdutoMisto(u, v, w));

         
            int[] CriarVetor(int valorX, int valorY, int valorZ)
            {
                int[] newVetor = new int[] { valorX, valorY, valorZ };
                Console.WriteLine("u = <{0}, {1}, {2}>", valorX, valorY, valorZ);
                return newVetor;
            }

            int CalculoProdutoMisto(int[] vetor1, int[] vetor2, int[] vetor3)
            {
                

                int termo1 = vetor1[0] * vetor2[1] * vetor3[2]; //+
                int termo2 = vetor1[1] * vetor2[2] * vetor3[0]; //+
                int termo3 = vetor1[2] * vetor2[0] * vetor3[1]; //+
                int termo4 = vetor1[0] * vetor2[2] * vetor3[1]; //-
                int termo5 = vetor1[1] * vetor2[0] * vetor3[2]; //-
                int termo6 = vetor1[2] * vetor2[1] * vetor3[0]; //-

                //Console.WriteLine(termo1);
                //Console.WriteLine(termo2);
                //Console.WriteLine(termo3);
                //Console.WriteLine(termo4);
                //Console.WriteLine(termo5);
                //Console.WriteLine(termo6);


                return  termo1 + termo2 + termo3 - termo4 - termo5 - termo6;
            }
            #endregion

            #region Angulo_de_retas

            _WriteLine("Aula anterior - exercícios sobre o estudo da reta");
            _WriteLine("Vetorial: X = A + ");


            _WriteLine("Angulo entre retas");
            LineJump(2);
            _WriteLine("O angulo formado entre seus vetores diretores");
            _WriteLine("Exemplo: calculea medida em graus do ângulo as retas 'r' e 's', sendo");




            #endregion

            void LineJump(int linhas)
            {
                for (int i = 0; i < linhas; i++)
                {
                    Console.WriteLine();
                }
            }
            void _WriteLine(string text)
            {
                Console.WriteLine(text);
            }
            void _Write(string text)
            {
                Console.Write(text);
            }

        }


    }
}
