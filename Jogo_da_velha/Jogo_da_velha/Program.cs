using System;

namespace Jogo_da_velha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");





            #region Organization methods
            void Space(int x)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(" ");
                }

            }
            void Line(int y)
            {
                for (int i = 0; i < y; i++)
                {
                    Console.WriteLine();
                }
            }
            #endregion
        }
    }
}
