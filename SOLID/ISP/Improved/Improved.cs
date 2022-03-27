namespace SOLID.ISP.Improved;

/// <summary>
/// Better design. Follows ISP.
///
/// Simple solution is to split large interface
/// into two. Same logic behind SRP but for interfaces.
/// </summary>
internal interface ICustomer
{
    Customer GetCustomer();
    Customer AddCustomer();
    Customer UpdateCustomerName();
}

internal interface IOrder
{
    Order GetOrder();
    Order AddOrder();
    Order UpdateOrder();
}