using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetutrade_Model.Models
{
    public class BlogText
    {
        public int BlogTextID { get; set; }
        [ForeignKey("blogID")]
        public int blogID { get; set; }
        public Blog blog { get; set; }
        public string blogTitle { get; set; }
        public string blogSpotText { get; set; }
        public string blogDescription { get; set; }
        public string url { get; set; }
        public string Language { get; set; }
    }
}
