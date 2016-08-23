using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___256_Shades_of_Gray.Distances
{
    public interface IDistance
    {
        double Between(int[] pixels1, int[] pixels2);
    }
}
