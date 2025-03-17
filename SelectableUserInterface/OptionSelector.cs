namespace SelectableUserInterface;

public class OptionSelector(IList<Option> options) : ISelector<Option>
{
    private bool selected;
    private int caretIndex;
    
    public bool Selected => selected;
    public int CaretIndex => caretIndex;

    public IList<Option> Options => options;

    public void Select()
    {
        if (caretIndex < 0 || caretIndex >= Options.Count) return;
        selected = true;
        
        options[caretIndex].Action.Invoke();
    }

    public void Deselect()
    {
        caretIndex = 0;
        selected = false;
    }
    
    public void MoveCaretUp()
    {
        if (caretIndex <= 0)
        {
            caretIndex = Options.Count - 1;
        }
        else
        {
            caretIndex--;
        }
    }

    public void MoveCaretDown()
    {
        if (caretIndex >= Options.Count - 1)
        {
            caretIndex = 0;
        }
        else
        {
            caretIndex++;
        }
    }
}