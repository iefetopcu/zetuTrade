using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetutrade_Model.Models
{
    public class Offer
    {
        public int offerID { get; set; }
        [ForeignKey("orderID")]
        public int orderID { get; set; }
        public Order Order { get; set; }
        public double productPrice { get; set; }
        public double productTotalPrice { get; set; }
        public double offerTotalPrice { get; set; }
        public double shippingPrice { get; set; }
        public double discount { get; set; }
        [ForeignKey("statusID")]
        public int statusID { get; set; }
        public Status Status { get; set; }
    }
}
