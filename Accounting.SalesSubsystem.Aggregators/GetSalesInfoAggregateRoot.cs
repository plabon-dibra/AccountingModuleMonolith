using Accounting.SalesSubsystem.DTOs;
namespace Accounting.SalesSubsystem.Aggregators
{
    public class GetSalesInfoAggregateRoot
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
        public short NumberOfInvoices { get; set; }
        public bool Posted { get; set; }
        public int BillContactId { get; set; }
        public double? Tax { get; set; }
        public string? RefNo { get; set; }
        public int? TaxId { get; set; }
        public int? SalesPerson { get; set; }
        public int? Jsid { get; set; }
        public int? JpId { get; set; }
        public int? JciId { get; set; }
        public bool? Invalid { get; set; }

        public SalesInfoResponseDTO GetSalesInfoResponseDTO()
        {
            SalesInfoResponseDTO data = new SalesInfoResponseDTO();
            data.Tno = Tno;
            data.Pcode = Pcode;
            data.Cid = Cid;
            data.BillContactId = BillContactId;
            data.SalesPerson = SalesPerson;
            data.Sdate = Sdate;
            data.Edate = Edate;
            data.CashReceived = CashReceived;
            data.SalesPrice = SalesPrice;
            data.AccReceivable = AccReceivable;
            data.CashReceived = CashReceived;
            data.Comments = Comments;
            data.Duration = Duration;
            data.JpId = JpId;

            return data;
        }
    }
}
