namespace Zad4EmailsDecorator;

public interface IEmailSender
{
    void SendEmail(string to, string subject, string body);
}