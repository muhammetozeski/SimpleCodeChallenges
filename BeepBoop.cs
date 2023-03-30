// just for fun
// You can download the executable file from releases
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int frequency = 100;
        const int duration = 100;

        const int increaser = 100;

        bool increase = true;

        Console.Title = "Beep Boop";
        while (true)
        {
            Console.WriteLine(frequency);
            Console.Beep(frequency, duration);

            if (increase)
                frequency += increaser;
            else
                frequency -= increaser;

            if (frequency >= 7000)
                increase = false;

            if (frequency <= 100)
                increase = true;

        }
    }
}
