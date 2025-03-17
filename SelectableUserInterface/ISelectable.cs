namespace SelectableUserInterface;

public interface ISelectable
{
    bool Selected { get; }
    void Select();
    void Deselect();
}