using UKW_sklep_czw.Models;

namespace UKW_sklep_czw.Infrastructure
{
    public class CartItem
    {
        public Film Film { get; set; }

        public int Quantity { get; set; }

        public decimal? Value { get; set; }

    }
}