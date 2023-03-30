// just for fun
// You can download the executable file from releases
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int frequency = 100;
        const int duration = 200;

        const int increaser = 100;
        const int max = 1000;
        const int min = 100;

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

            if (frequency >= max)
                increase = false;

            if (frequency <= min)
                increase = true;

        }
    }
}
