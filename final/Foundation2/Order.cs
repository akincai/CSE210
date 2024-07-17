using System.Numerics;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public float CalculateSubtotal()
    {
        float sum = 0;
        foreach(Product p in _products)
            sum += p.CalculateTotal();
        // ternary expression to add 35 to the total if the customer is not a US resident
        sum += _customer.USResident() ? 0 : 35;

        return sum;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetMailingAddress()}";
    }

    public string GetPackingLabel()
    {
        string concat = "";
        foreach(Product p in _products)
            concat += $"{p.GetID()}:{p.GetName()} x{p.GetQuantity()}\n";
        return concat.Substring(0,concat.Length-1);
    }

    public void AddProducts(List<Product> products)
    {
        foreach(Product p in products)
            _products.Add(p);
    }
    public void AddProducts(Product product)
    {
        _products.Add(product);
    }
}