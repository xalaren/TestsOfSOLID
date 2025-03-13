namespace SingleResponsibilityPrinciple.Reports;

public interface IStorage<T>
{
    public IList<T> Items { get; }
}