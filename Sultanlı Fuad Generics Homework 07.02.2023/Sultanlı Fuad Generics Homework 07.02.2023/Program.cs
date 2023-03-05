using System;
namespace Sultanlı_Fuad_Generics_Homework_07._02._2023
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetDetails<string>("Orange");
            Swap<int>(8, 4);

        }

        static void GetDetails<T>(T type)
        {
            Console.WriteLine(type);
        }

        static void Swap<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}