using System;
class Program
{
    static void Main()
    {
        int F, x, y, z;
        double K;
        double max = 0;
        int count = 0;

        for (F = 100; F <= 999; F++)
        {

            x = F / 100;
            y = F / 10 % 10;
            z = F % 10;

            K = F / (x + y + z);
            if (K > max)
                //Я изменил знак на самое большое число на самое маленькое//
            {
                max = K;
                count = F;
            }
            Console.Write(K + " ");
        }
        Console.WriteLine("\nНаибольшее значение -> {0}", count);

        Console.ReadLine();
        //это самое большое число//
    }
}
