using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetutrade_Model.Models
{
    public class Category
    {
        public int categoryID { get; set; }
        public DateTime createtime { get; set; }
        public virtual ICollection<CategoryText> CategoryTexts { get; set; }
    }
}
