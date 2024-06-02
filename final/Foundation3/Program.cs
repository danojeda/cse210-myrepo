using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");


        // First, we create some 3 addresses:
       
        Address myAddress1 = new Address("Adams", "123", "Anchorage", "Alaska", "USA");
        Address myAddress2 = new Address ("Jefferson", "456", "West Memphis", "Arkansas", "USA");
        Address myAddress3 = new Address ("Madison", "789", "Calistoga", "California", "USA");

        //Now we create some dates and times:
        DateTime myDate1 = new DateTime(2024,6,30);
        DateTime myDate2 = new DateTime(2024,7,30);
        DateTime myDate3 = new DateTime(2024,8,30);

        TimeSpan myTime1 = new TimeSpan(11,30,0);
        TimeSpan myTime2 = new TimeSpan(16,30,0);
        TimeSpan myTime3 = new TimeSpan(15,30,0);
        // Now we create a Lecture event:
       

        Lecture myLecture = new Lecture("Michael Crichton", 90, "Dinosaurs of our life", "The importance of dinosaurs in our daily life by the author of Jurassic Park"
        ,myDate1,myTime1,myAddress1);

        //Now we create a Reception event:
       

        Reception myReception = new Reception("confirmation@EventCompany.net","John and Edith Wedding", "John and Edith are happy to share this happy day with you", myDate2
        ,myTime2,myAddress2);



        //Now we create an Outdoor Gathering event:
       
        OutdoorGathering myOutdoorGathering = new OutdoorGathering ("sunny", "Summer Marathon", "A lot of people running a lot and getting selfies", myDate3,myTime3,myAddress3);

        Console.WriteLine("Standard Details:  ");
       
        Console.WriteLine(myLecture.GetStandardDetails());
         Console.WriteLine(" ");
        Console.WriteLine("Full Details:");
        
        Console.WriteLine(myLecture.GetFullDetails());
        Console.WriteLine(" ");
        Console.WriteLine("Short Description:");
        Console.WriteLine(myLecture.ShortDescription());
        Console.WriteLine(" ");
        Console.WriteLine("============================================================================================");
        Console.WriteLine("Standard Details:  ");
        
        Console.WriteLine(myReception.GetStandardDetails());
        Console.WriteLine(" ");
        Console.WriteLine("Full Details:");
        
        Console.WriteLine(myReception.GetFullDetails());
        Console.WriteLine(" ");
        Console.WriteLine("Short Description:");
        Console.WriteLine(myReception.ShortDescription());
        Console.WriteLine(" ");
        Console.WriteLine("============================================================================================");
        Console.WriteLine("Standard Details:  ");
       
        Console.WriteLine(myOutdoorGathering.GetStandardDetails());
        Console.WriteLine(" ");
        Console.WriteLine("Full Details:");
        
        Console.WriteLine(myOutdoorGathering.GetFullDetails());
        Console.WriteLine(" ");
        Console.WriteLine("Short Description:");
        Console.WriteLine(myOutdoorGathering.ShortDescription());
        Console.WriteLine(" ");
        
 

    }
}