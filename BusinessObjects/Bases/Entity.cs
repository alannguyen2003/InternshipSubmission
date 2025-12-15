using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.Bases;

public abstract class Entity
{
    [Key]
    public Guid Id { get; set; }
}