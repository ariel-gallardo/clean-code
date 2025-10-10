using Common.Domain.DTOS.Base.Entities;

namespace Common.Domain.DTOS.Entities.User
{
    public class UserDTO : AuditableDTO
    {
        public string Userame { get; set; }
        public string Email { get; set; }
        public Guid? PersonaId { get; set; }
    }
}
