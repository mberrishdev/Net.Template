namespace Net.Template.Domain.Primitives;

[Serializable]
public abstract class Entity<TId>
{
    public virtual TId Id { get; set; }
}