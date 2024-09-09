using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVGiaiThua
{
    public class TVGiaiThua
    {
        public static long TinhGT_1(int number)
        {
            if (number == 0 || number == 1) return 1;

            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int TinhGT_1(object number)
        {
            throw new NotImplementedException();
        }
    }
}
