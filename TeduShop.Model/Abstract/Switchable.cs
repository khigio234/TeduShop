using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public abstract class Switchable : ISwitchable
    {
        public bool Status { get; set; }
    }
}