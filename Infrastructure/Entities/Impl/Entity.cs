
namespace Transport.Infrastructure.Entities.Impl
{
    using System.ComponentModel.DataAnnotations;

    public class Entity : IEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
