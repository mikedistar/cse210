using System;

class Program
{
    static void Main(string[] args)
    {
        // Contains list of addresses

        Address _firstAddress = new Address("Liberty st", "Free City", "Texas", "USA");
        Address _secondAddress = new Address("Sunny Road", "Waterton", "Mons Bay", "NotInUSA");
        
        // List of products

        Product _firstProduct = new Product("Chocolate", 23, 2.3f, 4);
        Product _secondProduct = new Product("Shirts", 27, 74.34f, 5);
        Product _thirdProduct = new Product("Jewels", 127, 999.99f, 1);
        Product _fourthProduct = new Product("Yarn", 3, 5.79f, 10);
        Product _fifthProduct = new Product("Meat", 29, 7.99f, 10);
        Product _sixthProduct = new Product("Picture frames", 54, 8.99f, 15);

        // List of customers

        Customer _firstCustomer = new Customer("Bob Miller", _firstAddress);
        Customer _secondCustomer = new Customer("Sarah Brown", _secondAddress);

        // List of Orders

        Order _firstOrder = new Order(_firstCustomer);
        Order _secondOrder = new Order(_secondCustomer);

        // Adding products to first order

        _firstOrder.AddProductsToList(_firstProduct);
        _firstOrder.AddProductsToList(_sixthProduct);
        _firstOrder.AddProductsToList(_fifthProduct);

        // Adding products to second order

        _secondOrder.AddProductsToList(_secondProduct);
        _secondOrder.AddProductsToList(_thirdProduct);
        _secondOrder.AddProductsToList(_fourthProduct);

        // Print labels for first customer/order

        _firstOrder.PrintShippingLabel();
        _firstOrder.PrintPackingLabel();
        _firstOrder.GetTotalCost();
        Console.WriteLine();

        // Print labels for second customer/order

        _secondOrder.PrintShippingLabel();
        _secondOrder.PrintPackingLabel();
        _secondOrder.GetTotalCost();
    }
}