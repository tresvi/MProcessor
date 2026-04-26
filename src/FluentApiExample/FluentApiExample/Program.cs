using FluentShoppingCart;

namespace FluentApiExample
{
    //https://www.youtube.com/watch?v=Oly1L5zDQlY
    /*
 * El metodo de entrada deberia ser un metodo estatico con un nombre que exprese bien la instencion en este caso .Create();
 * Cada paso en la cadena debe ocuparse de algo puntual y luego seguir con la misma a traves del siguiente paso. Primer Paso, creamos un cliente puntual, segundo paso, agregamos items
 * El ultimo metodo tambien deberia devolver un objeto, que es el objeto resultante con un nombre muy expresivo y acorde
 * */

    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = ShoppingCart.Create()
                .ForClient("Juan Pérez")
                .AddItem(i => i.WithName("Producto 1").WithPrice(100).WithQuantity(1))
                .AddItem(i => i.WithName("producto 2").WithPrice(250).WithQuantity(2))
                .AddItem(i => i.WithName("un nombre").WithPrice(200).WithQuantity(1))
                .Checkout()
                .SetDelivery(d => d.WithAddress("direccion 1").WithPostalCode("123"))
                .SetPayment(p => p.WithName("visa").WithSecurityCode("123"))
                .Process();
        }
    }
}
