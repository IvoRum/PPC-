namespace Zad4EmailsDecorator;

public class SignatureDecorator : EmailDecorator
{
    public SignatureDecorator(IEmailSender emailSender) : base(emailSender)
    {
    }

    public override void SendEmail(string to, string subject, string body)
    {
        // Add signature logic
        string bodyWithSignature = body + "\n\nSent from MyApplication";
        base.SendEmail(to, subject, bodyWithSignature);
    }
}