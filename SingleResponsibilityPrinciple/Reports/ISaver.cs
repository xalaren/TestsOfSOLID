namespace SingleResponsibilityPrinciple.Reports;

public interface ISaver<T>
{
    public void Save(T item, IStorage<T> storage);
}