using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class bai8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");

            List<Student> students = new List<Student>() 
            { 
                new Student { Id = 1, Name = "An", Score = 8 }, 
                new Student { Id = 2, Name = "Binh", Score = 6 }, 
                new Student { Id = 3, Name = "Chi", Score = 9 }, 
                new Student { Id = 4, Name = "Dung", Score = 7 } 
            };

            var result = students.Where(s => s.Score >= 8);

            Console.WriteLine("sinh vien co diem >= 8: " + string.Join(", ", result.Select(s => s.Name)));
            Console.ReadLine();
        }
    }
}
