using System;

namespace Hillel_Lesson16_HW
{
	public class ProductRepository : IRepository<Product>
	{

		private List<Product> _products = new List<Product>();

        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public void Delete(Product entity)
        {
            _products.Remove(entity);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetByID(int id)
        {
            return _products.FirstOrDefault(p => p.ID == id);
        }

        public void Update(Product entity)
        {
            var existingProduct = GetByID(entity.ID);
            if (existingProduct != null)
            {
                existingProduct.Name = entity.Name;
            }
        }
    }
}

