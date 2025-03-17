namespace SelectableUserInterface;

public abstract class SelectableUI(OptionSelector optionSelector, string title = "") : UI, IKeysHandling
{
    public string Title { get; } = title;
    public abstract void Run();
    public abstract void Clear();
    public abstract void Print(string text, AccentColors accentColor);

    public void Draw()
    {
        Clear();

        if (!string.IsNullOrWhiteSpace(title))
        {
            Print(title + "\n\n", AccentColors.Main);
        } 
        
        for (int i = 0; i < optionSelector.Options.Count; i++)
        {
            string text = $"[{i + 1}]: {optionSelector.Options[i].Title}\n";
            if (i == optionSelector.CaretIndex)
            {
                Print(text, AccentColors.Secondary);
                continue;
            }
            
            Print(text, AccentColors.Main);
        }
    }

    public void OnEnter()
    {
        if (optionSelector.Selected)
        {
            optionSelector.Deselect();
            Draw();
        }
        else
        {
            Clear();
            optionSelector.Select();
            Print("\nBack <<<\n", AccentColors.Secondary);
        }
    }

    public void OnArrowDown()
    {
        if (optionSelector.Selected) return;
        
        optionSelector.MoveCaretDown();
        Draw();
    }

    public void OnArrowUp()
    {
        if (optionSelector.Selected) return;
        
        optionSelector.MoveCaretUp();
        Draw();
    }
}