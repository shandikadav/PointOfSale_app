using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_OF_SALE.Model.Entity
{
    public class Barang
    {
        public string BarangId {  get; set; }
        public string BarangName { get; set;}
        public int? StokBarang {  get; set; }
        public int? Price {  get; set; }
    }
}
