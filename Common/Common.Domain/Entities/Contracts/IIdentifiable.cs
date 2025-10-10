namespace Common.Domain.Entities.Contracts
{
    public interface IIdentifiable : IEntity
    {
        Guid Id { get; set; }
    }
}
