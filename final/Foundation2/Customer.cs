public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }


    public bool USResident()
    {
        return _address.InUSA();
    }

    public string GetMailingAddress()
    {
        return _address.GetMailingAddress();
    }

    public string GetName()
    {
        return _name;
    }
}