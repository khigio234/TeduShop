using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string TagId { get; set; }

        [Key]
        public int ProductId { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}