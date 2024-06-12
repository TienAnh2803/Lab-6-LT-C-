using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     class Program
    {
        static void Main(string[] args)
        {
        List <int> ListInt = new List<int>() { 2, 4, 5, 6, 7, 8, 9, 302,299, 301, 285};
        List<string> ListString = new List<string>() { null, "T1", "T2", "T3", null };
        List<string> ListNull = new List<string>();

        // cau a

        int score = ListInt.FirstOrDefault(num => num > 5 && num % 2 == 0);
        if(score != 0)
        {
            Console.WriteLine("So chan dau tien lon hon 5 la:" + score);
        }
        else
        {
            Console.WriteLine("Khong co so chan");
        }
        
        //cau b
        
        int score300 = ListInt.FindLast(num => num > 300);
        Console.WriteLine("So cuoi cung lon hon 300 la:" + score300);
        
        //cau c
        var firstText = ListString.FirstOrDefault(str => str != null && str.StartsWith("T", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Xuat ra phan tu co chu 'T' dau tien:" + firstText);   
        }
    }

