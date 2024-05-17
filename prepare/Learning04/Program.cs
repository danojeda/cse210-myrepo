using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment myAssignment = new Assignment ("Samuel Bennet", "Multiplication");
        String assignmentDetail=myAssignment.GetSummary();
        Console.WriteLine(assignmentDetail);

        MathAssignment myMathAssignment = new MathAssignment ("7.3","8-19","Daniel Ojeda","Fractions");
        String assignmentDetail2 = myMathAssignment.GetSummary();
        String homeworkDetail2 = myMathAssignment.GetHomeworkList();

        Console.WriteLine(assignmentDetail2);
        Console.WriteLine(homeworkDetail2);

        // public WritingAssignment (String title, String name, String topic): base (name,topic)
        WritingAssignment myWritingAssignment = new WritingAssignment("The Causes of World War II by Mary Waters","Mary Waters","European History");
        String assignmentDetail3 = myWritingAssignment.GetSummary();
        String homeWorkDetail3 = myWritingAssignment.GetWritingInformation();

        Console.WriteLine(assignmentDetail3);
        Console.WriteLine(homeWorkDetail3);

        
    }
}


 /*
        Mary Waters - European History
        The Causes of World War II by Mary Waters

        Roberto Rodriguez - Fractions
        Section 7.3 Problems 8-19
        */