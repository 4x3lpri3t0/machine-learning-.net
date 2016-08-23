using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___256_Shades_of_Gray
{
    class Program
    {
        static void Main()
        {
            var trainingPath = @"..\..\trainingsample.csv";
            var training = DataReader.ReadObservations(trainingPath);

            Console.ReadLine();
        }
    }
}
