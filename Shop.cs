using System;


namespace Hillel_Lesson16_HW
{
	public class Shop
	{

		public int ID { get; set; }
		public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }



        public Shop()
        {
            this.Products = new HashSet<Product>();
        }

    }
}

