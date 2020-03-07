using System;

namespace SportEquipmentClasses
{
    public class clsOrder
    {
        public DateTime OrderDatePlaced { get; set; }
        public int OrderNumber { get; set; }
        public string OrderDescription { get; set; }
        public bool OrderCompleted { get; set; }
        public float OrderPrice { get; set; }
        public int CustomerID { get; set; }
    }
}