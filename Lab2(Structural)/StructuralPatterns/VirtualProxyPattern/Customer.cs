namespace StructuralPatterns;

public class Customer : ICustomer
{
    private readonly string _customerName;

    public Customer(string customerName)
    {
        _customerName = customerName;
        LoadCustomerDetails();
    }

    private void LoadCustomerDetails()
    {
        Console.WriteLine("Loading customer details");
    }
    
    public void DisplayCustomerDetails()
    {
        Console.WriteLine("Displaying customer details");
    }
}