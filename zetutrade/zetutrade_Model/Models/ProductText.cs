using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetutrade_Model.Models
{
    public class ProductText
    {
        public int productTextID { get; set; }
        [ForeignKey("productID")]
        public int productID { get; set; }
        public Product product { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string url { get; set; }
        public string Language { get; set; }       

    }
}
