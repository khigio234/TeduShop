using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(TypeName = "varchar", Order = 1)]
        [MaxLength(50)]
        public string TagId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int PostId { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }
    }
}