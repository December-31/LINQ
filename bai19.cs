using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19
{
    internal class bai19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");

            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5}; 

            var result = numbers.GroupBy(n => n)
                                .OrderByDescending(g => g.Count())
                                .Select(g => g.Key)
                                .First();

            Console.WriteLine("so xuat hien nhieu nhat: " + result);
            Console.ReadLine();
        }
    }
}
