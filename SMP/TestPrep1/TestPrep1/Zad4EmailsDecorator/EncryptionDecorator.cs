namespace Zad4EmailsDecorator;

public class EncryptionDecorator : EmailDecorator
{
    public EncryptionDecorator(IEmailSender emailSender) : base(emailSender)
    {
    }

    public override void SendEmail(string to, string subject, string body)
    {
        // Add encryption logic
        string encryptedBody = Encrypt(body);
        base.SendEmail(to, subject, encryptedBody);
    }

    private string Encrypt(string body)
    {
        // Encryption logic...
        return "Encrypted: " + body;
    }
}