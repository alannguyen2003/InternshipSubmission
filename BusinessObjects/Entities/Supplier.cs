using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessObjects.Bases;

namespace BusinessObjects.Entities;

[Table("tbl_DM_NCC")]
public class Supplier : Entity
{
    [Required]
    [StringLength(50)]
    [Column("Ma_NCC")]
    public string SupplierCode { get; set; }
    
    [Required]
    [StringLength(255)]
    [Column("Ten_NCC")]
    public string SupplierName { get; set; }
    
    [Column("Ghi_Chu")]
    public string Notes { get; set; }
}