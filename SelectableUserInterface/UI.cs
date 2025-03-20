namespace SelectableUserInterface;

public interface UI : IRunnable
{
    string Title { get; }
    void Draw();
    void Clear();
    void Print(string text, AccentColors accentColor);
}