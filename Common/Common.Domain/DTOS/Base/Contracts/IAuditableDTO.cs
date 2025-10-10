namespace Common.Domain.DTOS.Base.Contracts
{
    public interface IAuditableDTO : IIdentifiableDTO
    {
        Guid CreatedById { get; set; }
        Guid? UpdatedById { get; set; }
        Guid? DeletedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
