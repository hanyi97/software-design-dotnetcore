namespace SOLID.DIP.Violation;

/// <summary>
/// Violates DIP.
///
/// 1. The business logic should not depend on the CustomerDataProcessor
/// and instead both classes should depend on abstraction.
/// 2. Abstractions should not depend on details. Details should depend
/// on abstractions.
/// </summary>
internal class CustomerDomain
{
    private readonly CustomerDataProcessor _customerDataProcessor;

    CustomerDomain(CustomerDataProcessor customerDataProcessor)
    {
        _customerDataProcessor = customerDataProcessor;
    }

    internal Customer CreateCustomer(Customer customer)
    {
        return _customerDataProcessor.AddCustomer(customer);
    }

    internal Customer GetCustomer(int id)
    {
        return _customerDataProcessor.GetCustomer(id);
    }
}

internal class CustomerDataProcessor
{
    internal Customer GetCustomer (int id)
    {
        return new Customer();
    }

    internal Customer AddCustomer(Customer customer)
    {
        return new Customer();
    }

    internal Customer UpdateCustomer(Customer customer)
    {
        return new Customer();
    }
}