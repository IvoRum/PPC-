namespace Zad4EmailsDecorator;

public abstract class EmailDecorator : IEmailSender
{
    private readonly IEmailSender _emailSender;

    protected EmailDecorator(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public virtual void SendEmail(string to, string subject, string body)
    {
        _emailSender.SendEmail(to, subject, body);
    }
}