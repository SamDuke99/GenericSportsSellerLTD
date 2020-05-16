using System;

namespace SportEquipmentClasses
{
    public class clsStock
    {
        public int ProductId { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }
        public DateTime DateAcquired { get; set; }
        public bool Result { get; set; }
        public bool Find(int ProductID)
        {
            return true;
        }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public string Brand { get; set; }

    }
}