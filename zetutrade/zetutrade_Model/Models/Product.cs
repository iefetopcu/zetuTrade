using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetutrade_Model.Models
{
    public class Product
    {
        public int productID { get; set; }      
        public string productPhotoUrl { get; set; }        
        [ForeignKey("categoryID")]
        public int categoryID { get; set; }
        public Category Category { get; set; }
        [ForeignKey("userID")]
        public int userID { get; set; }
        public User User { get; set; }
        public Boolean isinstock { get; set; }
        public DateTime createtime { get; set; }
        public DateTime updatetime { get; set; }

        public virtual ICollection<ProductText> ProductTexts { get; set; }
    }
}
