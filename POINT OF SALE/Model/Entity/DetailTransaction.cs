using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_OF_SALE.Model.Entity
{
    public class DetailTransaction
    {
        public string IdDetailTransaction {  get; set; }
        public string ProductID {  get; set; }
        public int Qty { get; set; }
        public int Total {  get; set; }
    }
}
