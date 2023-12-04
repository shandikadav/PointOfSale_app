using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_OF_SALE.Model.Entity
{
    public class User
    {
        public string IdUser {  get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }
        public string IdEmployee {  get; set; }
    }
}
