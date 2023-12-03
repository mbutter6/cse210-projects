using System;

class Program
{
    static void Main(string[] args)
    {

        {
            List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 03), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 03), 30, 15.0),
            new Swimming(new DateTime(2022, 11, 03), 30, 10)
        };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }
        }
    }

}
