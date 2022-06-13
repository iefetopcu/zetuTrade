using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetutrade_Model.Models
{
    public class Status
    {
        [Key]
        public int statusID { get; set; }
        public string statusName { get; set; }
    }
}
