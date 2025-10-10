namespace Common.Domain.DTOS.Base.Contracts
{
    public interface IIdentifiableDTO : IEntityDTO
    {
        Guid Id { get; set; }
    }
}
