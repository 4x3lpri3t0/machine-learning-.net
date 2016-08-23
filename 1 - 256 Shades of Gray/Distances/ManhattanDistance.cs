using System;

namespace _1___256_Shades_of_Gray.Distances
{
    public class ManhattanDistance : IDistance
    {
        public double Between(int[] pixels1, int[] pixels2)
        {
            if (pixels1.Length != pixels2.Length)
            {
                throw new ArgumentException("Inconsistent image seizes.");
            }

            int length = pixels1.Length;

            int distance = 0;

            for (int i = 0; i < length; i++)
            {
                distance += Math.Abs(pixels1[i] - pixels2[i]);
            }

            return distance;
        }
    }
}
