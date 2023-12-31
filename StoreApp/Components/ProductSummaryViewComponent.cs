using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services.Contracts;
using SQLitePCL;

namespace StoreApp.Components
{
    public class ProductSummary : ViewComponent
    {
        private readonly IServiceManager _manager;

        public ProductSummary(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager.ProductService.GetAllProducts(false).Count().ToString();
    
        }
        
    }
}