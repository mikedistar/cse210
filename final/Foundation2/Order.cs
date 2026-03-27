using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Order
{

    // List of attributes
    
    private List<Product> _products = new List<Product>();

    private float _totalPrice;

    private float _totalCost;

    private Customer _customer;

    // List of methods

    public Order(Customer customer)
    {

        _customer = customer;

    }
    
    public void PrintShippingLabel()
    {
        Console.WriteLine(_customer.GetCustomerName());
        Console.WriteLine(_customer.GetAddress());
    }

    public void PrintPackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.Write($"{product.GetProductName()}: ");
            Console.WriteLine(product.GetProductID());
        }
    }

    public void SetTotalPrice()
    {
        _totalPrice = 0;

        foreach(Product product in _products)
        {
            _totalPrice += product.GetTotalCostOfProduct();
        }
    }

    public void SetShippingCost()
    {
        SetTotalPrice();
        _totalCost = _totalPrice + (_customer.CheckIfInUSA()? 5: 35);
    }

    public void GetTotalCost()
    {
        SetShippingCost();
        Console.WriteLine($"${_totalCost:0.00}");
    }

    public void AddProductsToList(Product product)
    {
        _products.Add(product);
    }
    
}