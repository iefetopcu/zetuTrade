using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetutrade_Model.Models
{
    public class Order
    {
        public int orderID { get; set; }
        [ForeignKey("productID")]       
        public int productID { get; set; }
        public Product Product { get; set; }
        public string orderEmail { get; set; }
        public string orderNameSurname { get; set; }
        public string orderAddress { get; set; }
        public int orderNumber { get; set; }
        public DateTime ordertime { get; set; }      
    }
}
