using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    internal class bai16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            var result = numbers.Sum();

            Console.WriteLine("tong cac so trong danh sach: " + result);
            Console.ReadLine();

        }
    }
}
