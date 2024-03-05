namespace Zad2;

public abstract class Message
{
    IMessageSender MessageSender { get; set; } 

    string Subject { get; set; } 

    string Body { get; set; } 
    
    public abstract void Send();
}