using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Core.Models.Stocks.Products
{
    public class StockState
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string LotSerial { get; set; }
        public int StockQuantity { get; set; }=0;
        public int ShelfQuantity { get; set; } = 0;
        public int BranchQuantity { get; set; }=0;
        public int ConsignmentQuantity { get; set; } = 0;
        public int TransferedProductQuantity { get; set; }=0;

    }
}
