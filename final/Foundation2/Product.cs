public class Product
{
    private string _productName;
    private int _productId;
    private int _quantity;

    private double _price;


    public Product (string prodName, int productId, int quantity, int price)
    {
        _productName=prodName;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }
    public double GetTotalCost()
    {    
       
        return (_quantity * _price);

    }

    public int GetProductId()
    {
        return _productId;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductQuantity()
    {
        return _quantity;
    }

    public double GetProductPrice()
    {
        return _price;
    }

  
}