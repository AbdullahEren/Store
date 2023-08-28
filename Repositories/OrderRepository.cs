using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<Order> Orders => _context.Orders
        .Include(o => o.Lines)
        .ThenInclude(cl => cl.Product)
        .OrderBy(o => o.Shipped)
        .ThenByDescending(o => o.OrderId);

        public int NumberOfInProcess => _context.Orders.Count(o => o.Shipped.Equals(false));

        public void Complete(int id)
        {
            var order = FindByCondition(o => o.OrderId.Equals(id),true);
            if(order is null)
            {
                throw new System.Exception("Order not found");
                
            }
            order.Shipped = true;
            _context.SaveChanges();
        }

        public Order? GetOneOrder(int id)
        {
            return FindByCondition(o => o.OrderId.Equals(id),false);
        }

        public void SaveOrder(Order order)
        {
            _context.AttachRange(order.Lines.Select(l => l.Product));
            if(order.OrderId.Equals(0))
            {
                _context.Orders.Add(order);
            
            }
            _context.SaveChanges();
        }
    }
}