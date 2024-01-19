using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] v = new string[20,20];
            int i, j, k, s, ok;
            DateTime timp = DateTime.Now;
            //Console.WriteLine(timp);
            string vector = timp.ToString("HHmmss");
            Console.WriteLine(vector);
            for (i = 1; i < 9; i++)
            {
                for (j = 1; j < 7; j++)
                {
                    //if (i + j == vector[k]) v[i, j] = "X ";
                    if ((i == 4 && j == 1) || (i == 8 && j == 1) || (i == 8 && j == 3) || (i == 8 && j == 5)) v[i, j] = "  ";
                    else v[i, j] = "O ";
                }
            }
            for (k = 0; k < vector.Length; k++)
            {
                s = 0;
                for (i = 1; i <= 8; i++)
                {
                    if (i == 1 || i == 2 || i == 4 || i == 8)
                    {
                        if (vector[k] == s)
                        {
                            v[i, k + 1] = "X ";
                            break;
                        }
                        else s = s + i;
                    }
                }
            }
            for (i = 8; i >=1; i--)
            {
                if (i == 8 || i == 4 || i == 2 || i == 1)
                {
                    for (j = 1; j < 7; j++)
                    {
                        Console.Write(v[i, j]);
                    }
                    Console.WriteLine();
                }
               
            }
        }
    }
}
