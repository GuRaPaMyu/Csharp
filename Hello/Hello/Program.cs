using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {

            int test = 1;
            string str;
            int[] ahoaho = new int[3];


            Console.WriteLine("Hello! C# World!");
            Console.WriteLine("Number:{0}", test);
            Console.WriteLine("てきとーな文字列を入力してください");
            str = Console.ReadLine();
            Console.WriteLine("Inputted:{0}", str);
            test = int.Parse(str);
            Console.WriteLine("Parsed:{0}", test);

            for (test = 0; test < 3; test++)
            {
                ahoaho[test] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0} {1} {2}", ahoaho[0], ahoaho[1], ahoaho[2]);

        }
    }
}