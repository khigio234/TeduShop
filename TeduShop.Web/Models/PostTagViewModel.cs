namespace TeduShop.Web.Models
{
    public class PostTagViewModel
    {
        public string TagId { get; set; }

        public int PostId { get; set; }

        public virtual TagViewModel Tag { get; set; }

        public virtual PostViewModel Post { get; set; }
    }
}