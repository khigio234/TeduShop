namespace TeduShop.Web.Models
{
    public class ProductTagViewModel
    {
        public string TagId { get; set; }

        public int ProductId { get; set; }

        public virtual TagViewModel Tag { get; set; }

        public virtual ProductViewModel Product { get; set; }
    }
}