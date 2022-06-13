using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetutrade_Model.Models
{
    public class Subscriber
    {
        [Key]
        public int subsID { get; set; }
        public string subsEmail { get; set; }
    }
}
