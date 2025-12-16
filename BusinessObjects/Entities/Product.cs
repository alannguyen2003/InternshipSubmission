using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessObjects.Bases;

namespace BusinessObjects.Entities;

[Table("tbl_DM_San_Pham")]
public class Product : Entity
{
     [Required]
     [StringLength(50)]
     [Column("Ma_San_Pham")]
     public string ProductCode { get; set; }
     
     [Required]
     [Column("Thu_Tu")]
     public int OrderNo { get; set; }
     
     [Required]
     [StringLength(255)]
     [Column("Ten_San_Pham")]
     public string ProductName { get; set; }
     
     [Required]
     [Column("Loai_San_Pham_ID")]
     public Guid ProductCategoryId { get; set; }
     
     [Required]
     [Column("Don_Vi_Tinh_ID")]
     public Guid UnitPriceId { get; set; }
     
     [Column("Ghi_Chu")]
     public string? Notes { get; set; }
     
     public virtual UnitPrice UnitPrice { get; set; }
     public virtual ProductCategory ProductCategory { get; set; }
}