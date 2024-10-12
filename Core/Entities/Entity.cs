


namespace Core.Entities;

public abstract class Entity<TId>

{
    public TId Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; internal set; }
    public DateTime UpdatedDate { get; internal set; }

    public TId DoctorId { get; set; }
}
