using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; int y;
            Console.Write("请输入第一个数");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入第一个数");
            y = Convert.ToInt32(Console.ReadLine());

            hy(x, y);
            sub(x, y);
            nul(x, y);
            div(x, y);

            Console.ReadLine();
        }
        static void hy(int x, int y)
        {
            Console.WriteLine("{0}+{1}={2}", x, y, x + y);
        }
        static void sub(int x, int y)
        {
            Console.WriteLine("{0}-{1}={2}", x, y, x - y);
        }
        static void nul(int x, int y)
        {
            Console.WriteLine("{0}*{1}={2}", x, y, x * y);
        }
        static void div(int x, int y)
        {
            try
            {
                Console.WriteLine("{0}/{1}={2}", x, y, x / y);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("输入有误" + ex.Message);//22521556454656
            }
        }

    }
}
