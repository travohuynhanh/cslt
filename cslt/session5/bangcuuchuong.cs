using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session5
{
    internal class bangcuuchuong
    {
        static void printMultiplicationTable()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($" {i} x {j} = {i * j}");
                }
            }
        }
        static void Main05(string[] args)
        {
            printMultiplicationTable();
        }
    }
}
