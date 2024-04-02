using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostics
{    internal static class Utils
    {
        public static void Swap(this int[] array, int indexA, int indexB) 
        {
            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;
        }
    }
}
