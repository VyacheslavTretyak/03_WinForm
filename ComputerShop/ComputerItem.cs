using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
	public class ComputerItem
	{
		public string Name { get; set; }
		public string Specification { get; set; }
		public string Description { get; set; }
		public float Price{ get; set; }
		public override string ToString()
		{
			return Name;
		}
	}
}
