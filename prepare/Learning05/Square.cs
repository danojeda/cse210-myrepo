public class Square : Shape
{
    private double _side;

    //Make sure this class inherits from the base class.
    //Create a constructor that accepts the color and the side, and then call the base constructor with the color.
    //Override the GetArea() method from the base class and fill in the body of this function to return the area.
    public Square(double side, String color) :base (color)
    {
        //base.Shape(string color);
        _side = side;
    }

   /* public double GetArea()
    {

    }
    */

    public override double GetArea()
    {
        return _side * _side;
    }

}