using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class Program
    {
        public static void Main()
        {
            var fun = new Functions();
            int[,] relieve = { { 9, 2, 2, 2, 3, 5 }, { 9, 8, 3, 2, 4, 5 }, { 9, 7, 2, 2, 4, 3 }, { 9, 9, 2, 4, 4, 3 }, { 9, 2, 3, 4, 3, 5 } };
            int[,] resultado = new int[5, 6];
            fun.encontrar_bordes(relieve, ref resultado);
        }
    }
}
