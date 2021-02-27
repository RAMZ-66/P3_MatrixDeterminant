using System;

namespace P3_MatrixDeterminant
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" ");
            
            int[,] matriz = new int[3,3] { {1,3,5}, {2,4,6}, {3,5,9} };
            
            for(int i = 0; i < 9; i++ )
            {
                if (i < 3)
                {
                    Console.Write(matriz[0,i] + " ");                   
                }

                else if (i < 6)
                {
                    if(i < 4)
                    {
                        Console.WriteLine("");
                    }
                    Console.Write(matriz[1,i - 3] + " ");

                }

                else if (i < 9)
                {
                    if(i < 7)
                    {
                        Console.WriteLine("");
                    }
                    Console.Write(matriz[2,i - 6] + " ");

                }
            
            }

            Console.WriteLine(" ");
            
            Console.WriteLine(" ");

            float determinante = ((1 * 4 * 9) + (2 * 5 * 5) + (3* 3 *6 )) - ((2 * 3 * 9) + (1 * 5 * 6) + (3 * 4 * 5));  
            // 1 3 5
            // 2 4 6
            // 3 5 9
            // 1 3 5
            // 2 4 6

            Console.Write("El determinante de esta matriz es: " + determinante);
            
                        
        }
    }
}
