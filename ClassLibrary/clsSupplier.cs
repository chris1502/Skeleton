using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Active { get; set; }
        public bool Stock { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int SupplierId { get; set; }
        public int SupplierFeedback { get; set; }
        public string SupplierProduct { get; set; }
        public int Price { get; set; }
    }
}