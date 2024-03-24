using Zad4EmailsDecorator;

class Program
{
    static void Main(string[] args)
    {
        // Create basic email sender
        IEmailSender basicEmailSender = new EmailSender();

        // Decorate the basic sender with encryption
        IEmailSender encryptedEmailSender = new EncryptionDecorator(basicEmailSender);

        // Decorate the encrypted sender with signature
        IEmailSender encryptedAndSignedEmailSender = new SignatureDecorator(encryptedEmailSender);

        // Send email using decorated sender
        encryptedAndSignedEmailSender.SendEmail("recipient@example.com", "Hello", "This is a secure email");

        Console.ReadLine();
    }
}