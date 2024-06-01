using System.Diagnostics;

public class Order
{
    private List<Product> _products = new List<Product>();
    Customer _idCustomer;


    public Order(List<Product> products, Customer idCustomer)
    {
        _products = products;
        _idCustomer = idCustomer;
    }

    public double CalculateTotal()
    {
        double price =0;
        foreach (Product product in _products)
        {
             price = price + product.GetTotalCost();
             
        }

       

        if (_idCustomer.VerifyLivesinUSA())
        {
            return price + 5;
        }else{
            return price +  35;
        }
        
    }

    public string GetPackingLabel()
    {   
        string packagingLabel="";
        foreach (Product product in _products)
        {   
            string thisProductName = product.GetProductName();
            int thisProductId = product.GetProductId();

            packagingLabel = packagingLabel + thisProductName + ", Product ID: " + Convert.ToString(thisProductId)+ "(Price:"+product.GetProductPrice()+")" +" Quantity: " + Convert.ToString(product.GetProductQuantity()) + " units."   ;
            packagingLabel += "\n";
                        
        }
        return packagingLabel;
    }

    public Customer  GetIdCustomer ()
    {
        return _idCustomer;
    }

    public void DisplayDetailsOrder()
    {
        Console.WriteLine("=========================================================================================");
        Console.WriteLine("=========================================================================================");
        Console.WriteLine("Product List");
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine("Customer:");
        //Console.Writeline(_idCustomer.GetShippingLabel());
        Console.WriteLine(_idCustomer.GetShippingLabel());
         Console.WriteLine();
        Console.WriteLine($"Total price: {CalculateTotal()} USD.");
        Console.WriteLine();
    }
    
}