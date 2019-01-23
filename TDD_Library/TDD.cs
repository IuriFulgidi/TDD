using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Library
{
    public static class TDD
    {
        public static int Max(int num1, int num2)
        {
            int ris = num1;
            if(num2>num1)
            {
                ris = num2;
            }
            return ris;
        }

    }
}
