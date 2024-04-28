using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers  =new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int element;
        int suma=0;
        int maximus=0;

        float average;
        do{
            element = int.Parse(Console.ReadLine());
            if (element !=0){
                numbers.Add(element);
                //Console.WriteLine($"{element}");
            }
            

        }while (element !=0);


        foreach (int number in numbers){
            suma += number;
            //Console.WriteLine($"{suma} >>> {number}");
        }
        Console.WriteLine($"The sum is: {suma}");

        average = ((float)suma) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        maximus = numbers.Max();
        Console.WriteLine($"The largest numner is : {maximus}");

    }

}