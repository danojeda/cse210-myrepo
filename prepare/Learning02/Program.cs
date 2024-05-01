using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine("********************************************************************************");
        Job job1 = new Job();

        job1._company = "Technical Solutions";
        job1._jobTitle = "Software Engineer";
        job1._starYear = 2018;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Great Solutions";
        job2._jobTitle = "Support Engineer";
        job2._starYear = 2020;
        job2._endYear = 2022;

       /*
        Console.WriteLine(job1._company);
        Cnsole.WriteLine(job2._company);*/

        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);
        resume1._personName = "John Doe";
        
        //Console.WriteLine(resume1._jobList[0]._jobTitle);
        resume1.DisplayResume();

    }
}

//Set the member variables using the dot notation (for example, job1._jobTitle = "Software Engineer";

/*Add the two jobs you created earlier, to the list of jobs in the resume object.
Verify that you can access and display the first job title using dot notation similar to myResume._jobs[0]._jobTitle .*/