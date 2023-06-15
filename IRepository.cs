using System;
namespace Hillel_Lesson16_HW
{
	public interface IRepository<T>
	{

		T GetByID(int id);

		IEnumerable<T> GetAll();

		void Add(T entity);

		void Update(T entity);

		void Delete(T entity);




	}
}

