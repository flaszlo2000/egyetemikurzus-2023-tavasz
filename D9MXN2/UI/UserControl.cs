using D9MXN2.DataAccess.Actions;

namespace D9MXN2.UI;

public class LoginScreen : CredentialHandler
{
    public override void Render(string? msg = null)
    {
        this.CredentialHandling(UserActions.Login);
    }
}

public class RegisterScreen : CredentialHandler
{
    public override void Render(string? msg = null)
    {
        this.CredentialHandling(UserActions.Register);
    }

}