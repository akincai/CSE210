public class Product
{
    private string _name;
    private string _ID;
    private float _price;
    private int _quantity;

    public Product(string name, string ID, float price, int quantity)
    {
        _name = name;
        _ID = ID;
        _price = price;
        _quantity = quantity;
    }


    public float CalculateTotal()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetID()
    {
        return _ID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}