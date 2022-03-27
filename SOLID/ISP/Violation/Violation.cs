namespace SOLID.ISP.Violation;

/// <summary>
/// Violates ISP.
///
/// Interface should be responsible for just one thing
/// and if we implement this class with the intention of working only our
/// Customer logic, we would be forced to implement the Order methods without
/// the need of using them.
/// </summary>
internal interface ICustomer
{
    Customer GetCustomer();
    Customer AddCustomer();
    Customer UpdateCustomerName();
    Order GetOrder();
    Order AddOrder();
    Order UpdateOrder();
}