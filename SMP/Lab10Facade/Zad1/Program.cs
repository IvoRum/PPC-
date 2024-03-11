using Zad1;

public class Manager
{
    static void Main()
    {
        TextEditor textEditor = new TextEditor(); 
        Compiller compiller = new Compiller(); 
        CLR clr = new CLR(); 
        VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr); 
        Programmer programmer = new Programmer();
        programmer.CreateApplication(ide);
    }
}