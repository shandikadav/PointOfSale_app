using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_OF_SALE.Model.Entity
{
    public class Transaction
    {
        public string IdTransaction {  get; set; }
        public int? GrandTotal { get; set; }
        public int? TotalProduct {  get; set; }
        public DateTime DateTime { get; set; }
        
        public int? TotalPayment {  get; set; }
        public int? Kembalian { get; set; }
        public string IdPayment { get; set; }
        public string IdEmployee{ get; set; }
        public string IdDetailTransact { get; set; }

    }
}
