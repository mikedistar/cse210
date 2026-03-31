public class Address
{
    
    // List of Address attributes

    private string _street;

    private string _city;

    private string _stateOrProvince;

    private string _country;

    // List of Address methods

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;

        _city = city;

        _stateOrProvince = stateOrProvince;

        _country = country;
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}, {_stateOrProvince}, {_country}";
    }

}