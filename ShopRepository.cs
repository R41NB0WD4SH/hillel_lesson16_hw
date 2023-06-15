using System;
namespace Hillel_Lesson16_HW
{
	public class ShopRepository : IRepository<Shop>
	{

		private List<Shop> _shops = new List<Shop>();


        public void Add(Shop entity)
        {
            _shops.Add(entity);
        }

        public void Delete(Shop entity)
        {
            _shops.Remove(entity);
        }

        public IEnumerable<Shop> GetAll()
        {
            return _shops;
        }

        public Shop GetByID(int id)
        {
            return _shops.FirstOrDefault(s => s.ID == id);
        }

        public void Update(Shop entity)
        {
            var existingShop = GetByID(entity.ID);
            if (existingShop != null)
            {
                existingShop.Name = entity.Name;
            }
        }

    }
}

