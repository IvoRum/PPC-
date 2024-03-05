namespace Zad2;

public class SystemMessage:Message
{
    public override void Send()
    {
       
        
    }
    
    MessageSender.SendMessage(Subject, Body);
}