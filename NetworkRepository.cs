using System;
namespace Hillel_Lesson16_HW
{
	public class NetworkRepository : IRepository<Network>
	{

		private List<Network> _networks = new List<Network>();


        public void Add(Network entity)
        {
            _networks.Add(entity);
        }

        public void Delete(Network entity)
        {
            _networks.Remove(entity);
        }

        public IEnumerable<Network> GetAll()
        {
            return _networks;
        }

        public Network GetByID(int id)
        {
            return _networks.FirstOrDefault(p => p.ID == id);
        }

        public void Update(Network entity)
        {
            var existingNetwork = GetByID(entity.ID);
            if (existingNetwork != null)
            {
                existingNetwork.Name = entity.Name;
            }
        }

    }
}

