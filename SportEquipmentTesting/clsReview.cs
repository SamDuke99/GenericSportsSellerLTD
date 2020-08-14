using System;

namespace SportEquipmentTesting
{
    public class clsReview
    {

        public bool ReviewTrusted { get; internal set; }
        public DateTime ReviewDatePosted { get; internal set; }
        public int CustomerID { get; internal set; }
        public int ReviewID { get; internal set; }
        public string ReviewContent { get; internal set; }
        public float ReviewRating { get; internal set; }
        public decimal ReviewRating { get; internal set; }
    }
}
