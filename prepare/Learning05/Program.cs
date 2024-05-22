using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        
        Square mySquare = new Square(4,"red");
        String mySqColor = mySquare.GetColor();
        double mySqArea = mySquare.GetArea();
        Console.WriteLine($"the Color: {mySqColor}");
        Console.WriteLine($"The Area is {mySqArea}");

        List<Shape> myList = new List<Shape>();
        Square  my2Square = new Square (3, "blue");
        //  public Rectangle(double length, double width , string color) : base (color)
        Rectangle myRectangle = new Rectangle (3,4,"green");
        Circle myCircle = new Circle (3, "yellow");
        // public Circle (double radius, string color): base (color)
        myList.Add(my2Square);
        myList.Add(myRectangle);
        myList.Add(myCircle);

        foreach (Shape shape in myList)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"This shape has an area of {area} and is of color {color}");
        }

    }

    //Create a Square instance, call the GetColor() and GetArea() methods and make sure they return the values you expect.
    // public void Square(String color, double side )
  
}