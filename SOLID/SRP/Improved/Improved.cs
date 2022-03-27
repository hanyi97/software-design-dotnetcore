namespace SOLID.SRP.Improved;

/// <summary>
/// Better design.
///
/// Methods are separated into different classes
/// based on the functionality.
/// </summary>

internal class UserService
{
    private void Register(string email, string password)
    {
        throw new NotImplementedException();
    }
}

internal class EmailService
{
    private bool ValidateEmail(string email)
    {
        throw new NotImplementedException();
    }

    private bool SendEmail(string message)
    {
        throw new NotImplementedException();
    }
}