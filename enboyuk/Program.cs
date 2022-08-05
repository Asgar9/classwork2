using System;

namespace enboyuk
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("ededleri daxil edin:");
            Console.WriteLine(bigger(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        static int bigger(int num1,int num2,int num3)
        {
            if (num1>num2 && num1>num3 )
            {
                return num1;
            }
            if(num2>num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
