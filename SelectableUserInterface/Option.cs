namespace SelectableUserInterface
{
    public class Option
    {
        public string Title { get; init; } = string.Empty;
        public Action Action { get; init; } = () => { };
    }
}