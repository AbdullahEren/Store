using System.Text.Json.Serialization;
using Entities.Models;
using StoreApp.Infrastructe.Extensions;

namespace StoreApp.Models
{
    public class SessionCart : Cart
    {
        [JsonIgnore]
        public ISession? Session { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext?.Session;
            
            SessionCart? cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        override public void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session?.SetJson<SessionCart>("Cart", this);
        }
        override public void Clear()
        {
            base.Clear();
            Session?.Remove("Cart");
        }

        override public void RemoveLine(Product product)
        {
            base.RemoveLine(product);
            Session?.SetJson<SessionCart>("Cart", this);
        }

    }
}