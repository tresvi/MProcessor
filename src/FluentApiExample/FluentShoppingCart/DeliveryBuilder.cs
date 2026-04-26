using System;
using System.Collections.Generic;
using System.Text;

namespace FluentShoppingCart
{
    public interface IDeliveryBuilderStep1
    {
        IDeliveryBuilderStep2 WithAddress(string name);
    }

    public interface IDeliveryBuilderStep2
    {
        Delivery WithPostalCode(string name);
    }


    internal class DeliveryBuilder: IDeliveryBuilderStep1, IDeliveryBuilderStep2
    {
        private Delivery _delivery = new Delivery();
        public IDeliveryBuilderStep2 WithAddress(string name)
        {
            _delivery.Address = name;
            return this;
        }

        public Delivery WithPostalCode(string name)
        {
            _delivery.PostalCode = name;
            return _delivery;
        }
    }
}
