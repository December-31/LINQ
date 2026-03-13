using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class bai1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Cac so chan: " + string.Join(", ", result));
            Console.ReadLine();
        }
    }
}
