using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBI_PhasmoHelperV1
{
    static class PassTest
    {
        private static string password = "BBi";
        public static bool TestPassword(string input)
        {
            if (input == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
