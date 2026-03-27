public class Customer
{
    
    // List of Customer attributes

    private string _nameCustomer;

    private Address _address;

    // List of Customer methods

    public Customer(string nameOfCustomer, Address address)
    {
        _nameCustomer = nameOfCustomer;

        _address = address;
    }

    public string GetCustomerName()
    {
        return _nameCustomer;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public bool CheckIfInUSA()
    {
        return _address.CheckIfInUSA();
    }
}