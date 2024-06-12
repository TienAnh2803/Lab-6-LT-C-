using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> listInt2= new List<int>() { 5, 6, 7, 8, 1};

            Console.WriteLine("Giam dan");

            var Union = listInt1.Union(listInt2).OrderByDescending(x =>x);
            foreach(int union in Union)
            {
                Console.WriteLine(union + "");
            }
            var Interect = listInt1.Intersect(listInt2);
            Console.Write("Cac so chung: ");
            Console.WriteLine(" ");
            foreach (int interect in Interect)
            {
                Console.WriteLine(interect);
            }
            var Concat = listInt1.Concat(listInt2).OrderBy(x => x);
            Console.WriteLine("Cac so tang dan");
            Console.WriteLine(" ");
            foreach(int concat in Concat)
            {
                Console.WriteLine(concat);
            }
            var Except = listInt1.Except(listInt2);
            Console.WriteLine("Loai bo cac so chung: ");
            Console.WriteLine(" ");
            foreach(int except in Except)
            {
                Console.WriteLine(except);
            }    
        }
    }
}
