namespace SelectableUserInterface;

public interface IVerticalMoveable
{
    int CaretIndex { get; }
    void MoveCaretUp();
    void MoveCaretDown();
}