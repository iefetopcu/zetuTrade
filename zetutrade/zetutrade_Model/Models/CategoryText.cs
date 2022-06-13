using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetutrade_Model.Models
{
    public class CategoryText
    {
        public int categoryTextID { get; set; }
        [ForeignKey("categoryID")]
        public int categoryID { get; set; }
        public Category category { get; set; }

        public string categoryName { get; set; }
        public string Language { get; set; }
    }
}
