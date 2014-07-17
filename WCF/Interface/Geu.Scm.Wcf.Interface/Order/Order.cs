using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Interface.Order
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public string CompanyId { get; set; }
        [DataMember]
        public string OrderId { get; set; }
        [DataMember]
        public int OrderYear { get; set; }
        [DataMember]
        public int OrderStatusId { get; set; }
        [DataMember]
        public string SupplierId { get; set; }
        [DataMember]
        public string PlantId { get; set; }
        [DataMember]
        public System.DateTime IssueDate { get; set; }
        [DataMember]
        public string LineId { get; set; }
        [DataMember]
        public string SeasonId { get; set; }
        [DataMember]
        public string SeasonDs { get; set; }
        [DataMember]
        public string OrganizationId { get; set; }
        [DataMember]
        public string OrderNumber { get; set; }
        [DataMember]
        public string CurrencyId { get; set; }
        [DataMember]
        public string PaymentTenorDaysCode { get; set; }
        [DataMember]
        public string PaymentTenorStartDateCode { get; set; }
        [DataMember]
        public string IncotermCode { get; set; }
        [DataMember]
        public string IncotermDs { get; set; }
        [DataMember]
        public string IncotermLocationCode { get; set; }
        [DataMember]
        public bool IsPartialShipmentAllowed { get; set; }
        [DataMember]
        public string ShipmentMethodCode { get; set; }
        [DataMember]
        public string ShipmentMethodDs { get; set; }
        [DataMember]
        public Nullable<int> OpenQuantity { get; set; }
        
    }
}
