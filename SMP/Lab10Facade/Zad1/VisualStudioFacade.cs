namespace Zad1;

public class VisualStudioFacade
{
    private TextEditor textEditor;
    private Compiller compiller;
    private CLR clr;

    public VisualStudioFacade(TextEditor textEditor, Compiller compiller, CLR clr)
    {
        this.textEditor = textEditor;
        this.compiller = compiller;
        this.clr = clr;
    }

    public void Start()
    {
        textEditor.CreateCode();
        textEditor.Save();
        compiller.Compile();
        clr.Execute();
    }

    public void Stop()
    {
        clr.Finish();
    }
}