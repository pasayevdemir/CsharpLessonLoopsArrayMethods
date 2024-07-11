using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //{Ref,Out əməliyyatı}
            //int a = 20, b = 10;
            //Console.WriteLine(Tpl(ref a, b));
            //Console.WriteLine(a);
            Console.WriteLine(vrm(2, 4));
            Console.WriteLine(Add(1,2,50));
            Console.ReadLine();
        }
        static int vrm(int say1, int say2, int say3=1)
        {
            return say1 * say2 * say3;
        }
        //static int Tpl(ref int say1,int say2)
        //{
        //    say1 = 5;
        //    return say1 + say2;
        //}
        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
