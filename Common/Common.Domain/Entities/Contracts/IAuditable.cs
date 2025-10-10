namespace Common.Domain.Entities.Contracts
{
    public interface IAuditable : IIdentifiable
    {
        Guid CreatedById { get; set; }
        Guid? UpdatedById { get; set; }
        Guid? DeletedById { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        DateTime? DeletedAt { get; set; }
        User CreatedBy { get; set; }
        User UpdatedBy { get; set; }
        User DeletedBy { get; set; }
    }
}
