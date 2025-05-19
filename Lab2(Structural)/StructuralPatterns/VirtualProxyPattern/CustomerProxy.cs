namespace StructuralPatterns;

public class CustomerProxy : ICustomer
{
    private Customer? _customer;
    private readonly string _customerName;

    public CustomerProxy(string customerName)
    {
        _customerName = customerName;
    }
    
    public void DisplayCustomerDetails()
    {
        if (_customer == null)
        {
            _customer = new Customer(_customerName);
        }
        _customer.DisplayCustomerDetails();
    }
}