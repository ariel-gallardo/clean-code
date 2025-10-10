using Common.Domain.Entities.Contracts;

namespace Common.Domain.Entities.Base
{
    public class IdentifiableEntity : EntityBase, IIdentifiable
    {
        public Guid Id { get; set; }
    }
}
