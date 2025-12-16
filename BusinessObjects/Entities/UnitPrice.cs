using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessObjects.Bases;

namespace BusinessObjects.Entities;

[Table("tbl_DM_Don_Vi_Tinh")]
public class UnitPrice : Entity
{
    [Required]
    [StringLength(255)]
    [Column("Ten_Don_Vi_Tinh")] 
    public string UnitPriceName { get; set; } = null!;

    [StringLength(1000)]
    [Column("Ghi_Chu")] 
    public string? Notes { get; set; } = null;
    
    
    public virtual ICollection<Product> Products { get; set; }
}