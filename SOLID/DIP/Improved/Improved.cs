namespace SOLID.DIP.Improved;

/// <summary>
/// Better design. Follows DIP.
///
/// 1. High level module (CustomerDomain and CustomerDataProcessor) are
/// dependent on abstraction (ICustomerDomain and ICustomerDataProcessor).
/// 2. Abstraction do not depend on any details but details depend on abstraction.
/// </summary>
internal class CustomerDomain : ICustomerDomain
{
    private readonly ICustomerDataProcessor _customerDataProcessor;

    public CustomerDomain(ICustomerDataProcessor customerDataProcessor)
    {
        _customerDataProcessor = customerDataProcessor;
    }
    
    public Customer CreateCustomer(Customer customer)
    {
        return _customerDataProcessor.AddCustomer(customer);
    }

    public Customer GetCustomer(int id)
    {
        return _customerDataProcessor.GetCustomer(id);
    }
}

internal class CustomerDataProcesser : ICustomerDataProcessor
{
    public Customer GetCustomer(int id)
    {
        return new Customer();
    }

    public Customer AddCustomer(Customer customer)
    {
        return new Customer();
    }

    public Customer UpdateCustomer(Customer customer)
    {
        return new Customer();
    }
}

internal interface ICustomerDomain
{
    Customer CreateCustomer(Customer customer);
    Customer GetCustomer(int id);
}

internal interface ICustomerDataProcessor
{
    Customer GetCustomer(int id);
    Customer AddCustomer(Customer customer);
    Customer UpdateCustomer(Customer customer);
}
