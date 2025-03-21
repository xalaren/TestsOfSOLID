namespace SelectableUserInterface;

public interface ISelector<T> : ISelectable, IVerticalMoveable
{
    IList<T> Options { get; }
}