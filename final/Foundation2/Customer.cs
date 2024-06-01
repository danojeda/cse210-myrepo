using System.Net.Sockets;

public class Customer
{

    private string _customerName; 
    private Address _customerAddress;


    public Customer(string customerName, Address CustomerAddress)
    {
        _customerName = customerName;
        _customerAddress = CustomerAddress;
    }


    
    public bool VerifyLivesinUSA()
    {
        return _customerAddress.IsInUsa();
    }


    

    public string GetShippingLabel()
    {
        return _customerName + ", " +  _customerAddress.GetFullAddress();
    }


    
}