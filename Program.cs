using System;

namespace odev_3
{    internal class Program
    {
        static void Main(string[] args)
        {
            // atama
            int x = 3;
            int y = 3;
            y= y+2;
            //birleşebilir işlemli atama--> y+=2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2; //x=x*2
            Console.WriteLine(x);
            // Mantıksal Operatörler
            //||,&&,!
            bool isSuccess = true;
            Boolean isCompleted = false;

            if(isSuccess && isCompleted)
            Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
            Console.WriteLine("Perfect!");

            if(isSuccess && !isCompleted)
            Console.WriteLine("Final!");

            Console.Read();
        }
    }
}
