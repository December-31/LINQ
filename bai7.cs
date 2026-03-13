using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class bai7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = numbers.Any(n => n > 10);
            if (result)
                Console.WriteLine("co so lon hon 10 ");
            else
                Console.WriteLine("khong co so lon hon 10 " );
            Console.ReadLine();
        }
    }
}
