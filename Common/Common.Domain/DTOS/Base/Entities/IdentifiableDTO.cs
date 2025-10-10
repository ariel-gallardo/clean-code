using Common.Domain.DTOS.Base.Contracts;

namespace Common.Domain.DTOS.Base.Entities
{
    public class IdentifiableDTO : DTO, IIdentifiableDTO
    {
        public Guid Id { get; set; }
    }
}
