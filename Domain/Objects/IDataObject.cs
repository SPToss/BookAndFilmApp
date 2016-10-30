namespace Domain.Objects
{
    public interface IDataObject
    {
        bool IsDirty();
        int CountAllElements();
    }
}
