using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        int guess = 5;

        while (guess != magicNumber)

            Console.WriteLine("what is your guess?");
        guess = int.Parse(Console.ReadLine());

        if (magicNumber == guess)
        {
            Console.WriteLine("Correct");
        }

        else if (magicNumber < guess)
        {
            Console.WriteLine("Higher");
        }

        else
        {
            Console.WriteLine("Lower");
        }


    }

}


































