using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Classes
{
	class Product
	{
		int id;
		string name;
		double price;

		public void ProductDetails()
		{
			object[] array = new object[3];
			Console.WriteLine("Please Enter the Product Id :");
			id = Convert.ToInt32(Console.ReadLine());
			array[0] = id;
			Console.WriteLine("Please Enter the Product Name:");
			name = Console.ReadLine();
			array[1] = name;
			Console.WriteLine("Please Enter the Product price:");
			price = Convert.ToDouble(Console.ReadLine());
			array[2] = price;
			foreach(object obj in array)
			{
				Console.WriteLine(obj);
			}

		}
	}
}
