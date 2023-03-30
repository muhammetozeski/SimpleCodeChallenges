
using System;
using System.Collections.Generic;

class Program
{
    /// <summary> Safely gets an integer from user </summary>
    static int GetInt()
    {
        int Input = 0;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out Input))
                break;
            Console.WriteLine("Bad input. Enter an integer again:");
        }
        return Input;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            int frequency = 37;
            int duration = 1;

            Console.Write("Enter frequency: ");
            frequency = GetInt();

            Console.Write("Enter duration: ");
            duration = GetInt();

            Console.Beep(frequency, duration);
        }
    }
}
