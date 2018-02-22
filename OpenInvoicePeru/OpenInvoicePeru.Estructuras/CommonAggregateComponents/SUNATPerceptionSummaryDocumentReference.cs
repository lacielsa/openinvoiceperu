using OpenInvoicePeru.Estructuras.CommonBasicComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenInvoicePeru.Estructuras.CommonAggregateComponents
{
    public class SUNATPerceptionSummaryDocumentReference
    {
        public string SUNATPerceptionSystemCode { get; set; }
        public decimal SUNATPerceptionPercent { get; set; }
        public PayableAmount TotalInvoiceAmount { get; set; }
        public PayableAmount TotalPaid { get; set; }
        public PayableAmount TaxableAmount { get; set; }
        public decimal SUNATTotalCashed { get; set; }
    }
}
