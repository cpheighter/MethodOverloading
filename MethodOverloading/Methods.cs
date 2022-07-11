using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool z)
        {
            var total = x + y;
           
            
            
                if (total == 1  && z == true)
                {
                    return $"{total} dollar";
                }
                else if (total > 1 && z == true)
                {
                    return $"{total} dollars";
                }
                 else
                {
                return "Is False";
                }
            
        }
        
    }
}
