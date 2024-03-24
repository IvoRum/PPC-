namespace Zad4EmailsDecorator;

public class EmailSender:IEmailSender
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"Sending email to: {to}\nSubject: {subject}\nBody: {body}");
        // Logic to send email...
    }
}