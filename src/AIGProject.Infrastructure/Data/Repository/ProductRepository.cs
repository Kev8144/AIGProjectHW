using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using AIGProject.Application.Interfaces.IRepository;
using AIGProject.Domain.Entities;
using System.Collections.Generic;

namespace AIGProject.Infrastructure.Data.Repository 
{ 

    public class ProductRepository : BaseRepository<ProductRepository
        >, IProductRepository { 

        private readonly ILogger<ProductRepository> _logger;

        public ProductRepository(IConfiguration configuration, ILogger<ProductRepository> logger)
            : base(configuration, logger)
        {
            _logger = logger;
        }

        public void Add(Product product)
        {
            var id = QueryFirstOrDefault<int>(SqlQueries.ProductAdd, product);
            product.ProductId = id;
        }

        public Product Find(int id)
        {
            return QueryFirstOrDefault<Product>(SqlQueries.ProductFind,
                new { @ProductId = id });
        }

        public List<Product> GetAll()
        {
            return Query<Product>(SqlQueries.ProductGetAll);
        }

        public void Delete(int id)
        {
            Execute(SqlQueries.ProductDelete, new { id });
        }

        public void Update(Product product)
        {
            Execute(SqlQueries.ProductUpdate, product);
        }

}
}
