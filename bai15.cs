using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");

            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            var result = numbers.Distinct();

            Console.WriteLine("danh sach sau khi loai bo so trung: " + string.Join(", ", result));
            Console.ReadLine();
        }
    }
}
