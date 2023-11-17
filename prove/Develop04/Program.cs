using System;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity breathingActivity = new BreathingActivity();
        //breathingActivity.Menu = Console.ReadLine();
        breathingActivity.ActivityName = "Breathing Activity";
        breathingActivity.StartMessage = "Welcome to the Mindfullness App";
        breathingActivity.BreathingIntroduction = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        breathingActivity.GetBreathing();
        breathingActivity.EndMessage = "Thank you for taking time to look after yourself today.";


        ListingActivty listingActivty = new ListingActivty();
        listingActivty.ActivityName = "Listing Activity";
        listingActivty.StartMessage = "Welcome to the Mindfullness App";
        listingActivty.ListingIntroduction = "Welcome to the Listing Activity";
        listingActivty.GetLists();
        listingActivty.EndMessage = "Thank you for taking time to look after yourself today.";

        ReflectionActivity reflectionActivity = new ReflectionActivity();
        reflectionActivity.ActivityName = "Reflection Activity";
        reflectionActivity.StartMessage = "Welcome to the Mindfullness App";
        reflectionActivity.ReflectionIntroduction = "Welcome to the Reflection Activity";
        reflectionActivity.GetReflection();
        reflectionActivity.EndMessage = "Thank you for taking time to look after yourself today.";


    }
}

























