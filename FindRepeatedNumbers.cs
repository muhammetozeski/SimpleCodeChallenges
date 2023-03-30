/*
Challenge:
"Write a program to find repeated numbers within an array. The program will prompt the user to enter an array and then find the repeated numbers and print them out. For example, if the user enters 1, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8, 8, the program should output "Repeated Numbers: 4 6 8".

You can solve this question in any programming language such as C#, Python, or Java. Good luck!"
*/

//MyAnswer (worse one(check the second answer)):


namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            HashSet<int> RepeatedNumbers = new HashSet<int>();

            #region Get Inputs
            Console.WriteLine("Enter a number or leave empty and press enter:");
            while (true)
            {
                string? input = Console.ReadLine();
                if (input == string.Empty) break;

                if (int.TryParse(input, out int inputInt))
                    Numbers.Add(inputInt);
                else
                    Console.WriteLine("Wrong input");
            }
            Console.WriteLine(Numbers.Count + " numbers are taken from user");
            #endregion

            for (int i = 0; i < Numbers.Count; i++)
            {
                int NumberCount = 0;
                for (int i2 = 0; i2 < Numbers.Count; i2++)
                {
                    if (Numbers[i] == Numbers[i2])
                    {
                        if (++NumberCount > 1)
                            RepeatedNumbers.Add(Numbers[i]);
                    }
                }
            }
            Console.WriteLine("Repeated numbers:");
            foreach (var i in RepeatedNumbers)
                Console.Write(i + " ");

            Console.Beep(); //just for fun :)
        }
    }
}


//My second (better one) answer:
/*
class Program
{
    static void Main(string[] args)
    {
        List<int> Numbers = new List<int>();
        Dictionary<int, int> countDict = new Dictionary<int, int>();
        HashSet<int> RepeatedNumbers = new HashSet<int>();

        #region Get Inputs
        Console.WriteLine("Enter a number or leave empty and press enter:");
        while (true)
        {
            string? input = Console.ReadLine();
            if (input == string.Empty) break;

            if (int.TryParse(input, out int inputInt))
                Numbers.Add(inputInt);
            else
                Console.WriteLine("Wrong input");
        }
        Console.WriteLine(Numbers.Count + " numbers are taken from user");
        #endregion
        foreach (int num in Numbers)
        {
            if (countDict.ContainsKey(num))
            {
                countDict[num]++;
                if (countDict[num] > 1)
                    RepeatedNumbers.Add(countDict[num]);
            }
            else
            {
                countDict.Add(num, 1);
            }
        }

        Console.Write("Repeated Numbers: ");
        foreach (var i in RepeatedNumbers)
        {
            Console.Write(i + " ");
        }
    }
}
*/
