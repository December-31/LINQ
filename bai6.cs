using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class bai6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = numbers.Count(n => n % 2 == 0);

            Console.WriteLine("Co {0} so chan" , result);
            Console.ReadLine();

        }
    }
}
