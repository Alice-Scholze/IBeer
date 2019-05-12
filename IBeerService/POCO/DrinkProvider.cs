using System;

namespace IBeerService.POCO
{
    public class DrinkProvider
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public float Value { get; set; }
        public string Lot { get; set; }
        public DateTime ShelfLife { get; set; }
    }
}
