namespace FluentShoppingCart
{
    public class Client
    {
        public string Name { get; internal set; }

        public Client(string name)
        {
            this.Name = name;
        }
    }
}
