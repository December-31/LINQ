using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class bai2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = numbers.Where(n => n > 5);

            Console.WriteLine("Nhung so lon hon 5: " + string.Join(", ", result));
            Console.ReadLine();
        }
    }
}
