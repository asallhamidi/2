using System;

namespace _2
{
    class Program
    {
        static void Main()
        {
            double a, b, c, delta, x1, x2;
            Console.Write("a ra vared konid:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b ra vared konid:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c ra vared konid:");
            c = Convert.ToInt32(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("rishe nadarad");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 is {0},x2 is {1}", x1, x2);
            }
        }
    }
}
