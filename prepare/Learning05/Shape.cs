public class Shape 
{
    private String _color;

    //Create a constructor that accepts the color and set its.
    // Create a virtual method for GetArea().
    public  Shape(String color)
    {
        SetColor(color);
    }


    public String GetColor()
    {
        return _color;
    }

    public void SetColor (String color)
    {
        _color = color;
    }

    /*public double GetArea()
    {

    }*/

    public virtual double GetArea()
    {
        return 10000;
    }
}