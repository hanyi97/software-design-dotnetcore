namespace SOLID.SRP.Violation;

/// <summary>
/// This is not following SRP.
///
/// The ValidateEmail and SendEmail methods have
/// nothing to do within the UserService class.
/// </summary>
internal class UserService
{
    private void Register (string email, string password)
    {
        throw new NotImplementedException();
    }

    private bool ValidateEmail(string email)
    {
        throw new NotImplementedException();
    }

    private bool SendEmail(string message)
    {
        throw new NotImplementedException();
    }
}