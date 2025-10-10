using Common.Domain.DTOS.Base.Contracts;

namespace Common.Domain.DTOS.Base.Entities
{
    public class AuditableDTO : IdentifiableDTO, IAuditableDTO
    {
        public Guid CreatedById { get; set; }
        public Guid? UpdatedById { get; set; }
        public Guid? DeletedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is AuditableDTO dTO &&
                   CreatedById.Equals(dTO.CreatedById) &&
                   EqualityComparer<Guid?>.Default.Equals(UpdatedById, dTO.UpdatedById) &&
                   EqualityComparer<Guid?>.Default.Equals(DeletedById, dTO.DeletedById) &&
                   CreatedAt == dTO.CreatedAt &&
                   UpdatedAt == dTO.UpdatedAt &&
                   DeletedAt == dTO.DeletedAt;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CreatedById, UpdatedById, DeletedById, CreatedAt, UpdatedAt, DeletedAt);
        }
    }
}
