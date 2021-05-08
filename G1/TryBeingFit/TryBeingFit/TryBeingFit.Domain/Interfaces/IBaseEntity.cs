namespace TryBeingFit.Domain.Interfaces
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        string GetInfo();
    }
}
