

namespace FluentShoppingCart
{
    public interface IClientBuilder
    {
        IItemBuilder ForClient(string name);
    }

    public interface IItemBuilder
    {
        IItemBuilder AddItem(Func<IItemBuilderStep1, Item> itemConfigurator);
        ICheckoutBuilder Checkout();
    }

    public interface ICheckoutBuilder
    {
        IDeliveryBuilder SetDelivery(Func<IDeliveryBuilderStep1, Delivery> itemConfigurator);
        IDeliveryBuilder Checkout();
    }

    public interface IDeliveryBuilder
    {
        IPaymentBuilder SetPayment(Func<IPaymentBuilderStep1, Payment> paymentConfigurator);
    }

    public interface IPaymentBuilder
    {
        ShoppingCart Process();
    }
    
}
