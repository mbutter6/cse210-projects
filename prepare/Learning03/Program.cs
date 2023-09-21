using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());


        if (magicNumber == 5)
        {
            Console.WriteLine("Correct");
        }

        else if (magicNumber < 5)
        {
            Console.WriteLine("Higher");
        }

        else
        {
            Console.WriteLine("Lower");
        }


    }

}


































