using System;

namespace The_Area_Of_The_Cone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма расчета площади конуса");

            Console.WriteLine("Введите r - радиус основания");
            string a = Console.ReadLine();
            float r = Convert.ToSingle(a);
            
            Console.WriteLine("Введите l - oбразующая");
            string b = Console.ReadLine();
            float l = Convert.ToSingle(b);

            const Double pi = 3.141592653;
            double s = pi * r * (r + l);
            
            Console.WriteLine("Площадь конуса будет " + s);
            Console.ReadKey();
        }
    }
}
