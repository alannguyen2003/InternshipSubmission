using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessObjects.Bases;

namespace BusinessObjects.Entities;

[Table("tbl_DM_Loai_San_Pham")]
public class ProductCategory : Entity
{
    [Required]
    [Column("Ma_LSP")]
    public string CategoryCode { get; set; }
    
    [Required]
    [Column("Ten_LSP")]
    public string CategoryName { get; set; }

    [Required] 
    [Column("Thu_Tu")] 
    public int OrderNo { get; set; }

    [Column("Ghi_Chu")]
    public string? Notes { get; set; }
    
    public virtual ICollection<Product> Products { get; set; }
}