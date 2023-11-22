using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByRef_C_
{
    internal class Program
    {
        public void showResult(ref int value)
        {
            value += value;
            Console.WriteLine("Value: " + value);
        }
        static void Main(string[] args)
        {
            int data = 120;
            Program obj = new Program();
            Console.WriteLine("Before Calling: {0}", data);
            obj.showResult(ref data);
            Console.WriteLine("After Calling: {0}", data);
        }
    }
}
/*    
 Sample Output:

Before Calling: 120
Value: 240
After Calling: 240
 
 */
