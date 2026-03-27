public class Product
{
    
    // List of Product attributes

    private string _nameProduct;

    private int _productID;

    private float _pricePerUnit;

    private int _quantity;

    // List of Product methods

    public Product(string nameProduct, int productID, float pricePerUnit, int quantity)
    {
        _nameProduct = nameProduct;

        _productID = productID;

        _pricePerUnit = pricePerUnit;

        _quantity = quantity;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public string GetProductName()
    {
        return _nameProduct;
    }

    public float GetTotalCostOfProduct()
    {
        return _pricePerUnit * _quantity;
    }
}