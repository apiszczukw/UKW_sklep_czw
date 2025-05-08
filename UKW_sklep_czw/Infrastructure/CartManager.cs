using UKW_sklep_czw.DAL;

namespace UKW_sklep_czw.Infrastructure
{
    public static class CartManager
    {
        public static List<CartItem> GetItems(ISession session)
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(session, Consts.CartKey);

            if (cart == null)
            {
                cart  = new List<CartItem>();
            }

            return cart;
        }

        public static decimal? GetCartValue(ISession session)
        {
            var cart = GetItems(session);

            return cart.Sum(c => c.Value * c.Quantity);
        }

        public static void AddToCart(ISession session, int filmId, FilmsContext db)
        {
            var cart = GetItems(session);
            var newCartItem = cart.Find(c => c.Film.FilmId == filmId);

            if (newCartItem != null)
            {
                newCartItem.Quantity++;
            }
            else
            {
                var film = db.Films.Find(filmId);

                if (film != null)
                {
                    newCartItem = new CartItem()
                    {
                        Film = film,
                        Quantity = 1,
                        Value = film.Price
                    };

                    cart.Add(newCartItem);
                }
            }


            SessionHelper.SetObjectAsJson(session, cart, Consts.CartKey);
        }
    }
}
