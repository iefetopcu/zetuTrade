using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetutrade_Model.Models
{
    public class User
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string userSurname { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        [ForeignKey("userRoleID")]
        public int userRoleID { get; set; }
        public UserRole userRole { get; set; }
    }
}
