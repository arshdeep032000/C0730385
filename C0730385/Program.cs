using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730385
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 15;
            while(i<=20)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("{0}",sum);
            Console.ReadLine();
        }
    }
}
