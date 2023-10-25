using System;

class Program
{
    static void Main(string[] args)
    {

        WritingAssignment writingAssignment = new WritingAssignment();

        writingAssignment.StudentName = "Jane Doe";
        writingAssignment.Topic = "European History";
        writingAssignment.Title = "The Causes of World War II by Mary Waters";
        writingAssignment.GetSummary();
        writingAssignment.GetWritingInformation();

        MathAssignment mathAssignment = new MathAssignment();

        mathAssignment.StudentName = "John Doe";
        mathAssignment.Topic = "Fractions";
        mathAssignment.TextbookSection = "Section 7.3";
        mathAssignment.Problem = "Problems 8-19";
        mathAssignment.GetSummary();
        mathAssignment.GetHomeworkList();


    }




}