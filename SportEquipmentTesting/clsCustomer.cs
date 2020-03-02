using System;

namespace SportEquipmentTesting
{
    public class clsCustomer
    {

        public bool Active { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public int CountyNo { get; internal set; }
        public int AddressNo { get; internal set; }
        public string PostCode { get; internal set; }
        public string Street { get; internal set; }
        public string Town { get; internal set; }
    }
}