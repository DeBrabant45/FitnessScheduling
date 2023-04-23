
namespace Domain.Common;

public class IEntity 
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
}
