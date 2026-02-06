using System;

namespace InternetStore
{
    public class Shop
    {
        private Warehouse _warehouse;
        private Cart _cart;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
            _cart = new Cart();
        }

        public IReadOnlyCart Cart => _cart;

        public void PlaceGoodToCart(Good good, int count)
        {
            if (_warehouse.TryGetGoods(good, count))
            {
                _cart.Add(good, count);
            }
        }

        public Order Order()
        {
            return new Order();
        }
    }
}
