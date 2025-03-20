using SelectableUserInterface;

namespace TestsOfSOLID;

public class ConsoleSelectableUI(OptionSelector optionSelector, string title = "") : SelectableUI(optionSelector, title)
{
    public override void Run()
    {
        Clear();
        Draw();
        ReadKey();
    }

    public override void Clear() => Console.Clear();

    public override void Print(string text, AccentColors accentColor)
    {
        if (accentColor == AccentColors.Secondary)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.Write(text);
        Console.ResetColor();
    }
    
    private void ReadKey()
    {
        var key = Console.ReadKey().Key;
        OnReadKey(key);
    }

    private void OnReadKey(ConsoleKey consoleKey)
    {
        if (consoleKey == ConsoleKey.Enter) OnEnter();
        else if (consoleKey == ConsoleKey.UpArrow) OnArrowUp();
        else if(consoleKey == ConsoleKey.DownArrow) OnArrowDown();
        
        ReadKey();
    }
}