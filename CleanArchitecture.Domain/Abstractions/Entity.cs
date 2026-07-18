namespace CleanArchitecture.Domain.Abstractions;

public abstract class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; private set; } 
    public DateTime CreatedDate { get; private set; }
    public DateTime? UpdatedDate { get; private set; }


}