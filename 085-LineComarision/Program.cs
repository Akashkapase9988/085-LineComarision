using System;

namespace _085_LineComarision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinate point for line-1");
            Console.WriteLine("Enter coordinate point for line-1 for  X1 ||  Y2 cordiante ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate point for line-1 for  X2  || y2 cordiante ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double legth1 = Math.Sqrt(Math.Pow((x2 -x1 ), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("Length of line one is " + "  "+ legth1);
        }
    }
}
