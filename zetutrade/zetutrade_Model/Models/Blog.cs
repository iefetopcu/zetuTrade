using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetutrade_Model.Models
{
    public class Blog
    {
        public int blogID { get; set; }
        public int blogviews { get; set; }
        public string blogPhoto { get; set; }
        public DateTime releasetime { get; set; }
        public virtual ICollection<BlogText> BlogTexts { get; set; }
    }
}
