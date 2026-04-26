using System.Runtime.InteropServices;

namespace FluentShoppingCart
{
    public class ShoppingCart
    {
        public Payment Payment { get; internal set; }
        public Delivery Delivery { get; internal set; }
        public Client Client { get; internal set; }

        public static IClientBuilder Create()
        {
            var _builder = new ShoppingCartBuilder();
            return _builder;
        }

        DateTime _dateCreated;
        List<Item> _items;
    //    Delivery _delivery;
     //   Payment _payment;
      //  Client _client;



        public DateTime DateCreate { get => _dateCreated; }
        internal ShoppingCart()
        {
            //_client = client;
            _dateCreated = DateTime.Now;
            _items = new();
        }

        internal void AddItem(Item item)
        {
            _items.Add(item);
        }


        public double Total
        {
            get
            {
                double total = 0;
                _items.ForEach(i => total += i.Price * i.Quantity);

                return total;
            }

        }


    }
}
