using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.SalesSubsystem.DTOs
{
    public class SalesInfoResponseDTO
    {
        public int Tno { get; set; }
        public int Pcode { get; set; }
        public int Cid { get; set; }
        public DateTime Sdate { get; set; }
        public DateTime? Edate { get; set; }
        public double SalesPrice { get; set; }
        public double? CashReceived { get; set; }
        public double? AccReceivable { get; set; }
        public string? Comments { get; set; }
        public int Duration { get; set; }
        public int BillContactId { get; set; }
        public int? SalesPerson { get; set; }
        public int? JpId { get; set; }

    }
}
