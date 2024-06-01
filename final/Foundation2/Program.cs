using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

    

        // Create some 5 products:

        
        Product myProduct1 = new Product ("Sunglasses", 101,5, 100);
        Product myProduct2 = new Product ("Hat", 102,6,35);
        Product myProduct3 = new Product ("Boots", 103,4,90);
        Product myProduct4 = new Product ("Necklace", 201,10,150);
        Product myProduct5 = new Product ("Gloves", 202,10,55);
        
        
        Address myAddress1 = new Address ("Independence # 123","Miami","Florida","USA");
        Address myAddress2 = new Address ("Jefferson # 124","Miami","Florida","USA");
        Address myAddress3 = new Address ("Adams # 125","San Francisco","California","USA");
        Address myAddress4 = new Address ("San Martin # 231","Mendoza","Mendoza","Argentina");
        Address myAddress5 = new Address ("Madison # 323","Anchorage","Alaska","USA");
        Address myAddress6 = new Address ("Lincoln # 423","Boston","Massachussets","USA");
        

        // Now create 3 Customers:
        

        Customer myCustomer1 = new Customer ("Michael Kiske",myAddress1);
        Customer myCustomer2 = new Customer ("Kai Hansen", myAddress2);
        Customer myCustomer3 = new Customer ("Andi Deris", myAddress4);

        //Now create 3 lists of products:

        List<Product> productList1 = new List<Product> ();
        productList1.Add(myProduct1);
        productList1.Add(myProduct2);

        List<Product> productList2 = new List<Product> ();
        productList2.Add(myProduct3);
        productList2.Add(myProduct4);


        List<Product> productList3 = new List<Product> ();
        productList3.Add(myProduct5);
        productList3.Add(myProduct1);



        //Now create 3 orders:
        

        Order myOrder1 = new Order (productList1, myCustomer1);
        Order myOrder2 = new Order (productList2, myCustomer2);
        Order myOrder3 = new Order (productList3, myCustomer3);

        myOrder1.DisplayDetailsOrder();
        myOrder2.DisplayDetailsOrder();
        myOrder3.DisplayDetailsOrder();



       

    }



}