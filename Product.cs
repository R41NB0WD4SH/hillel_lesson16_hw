using System;

namespace Hillel_Lesson16_HW
{
	public class Product
	{
		

		public int ID { get; set; }
        public string Name { get; set; }

		public virtual ICollection<Shop> Shops { get; set; }



		public Product()
        {
            this.Shops = new HashSet<Shop>();
        }


    }


}

