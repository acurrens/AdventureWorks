using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductCategory
    {
		public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		//public ProductCategory(int ProductCategoryID_, Guid rowguid_, DateTime ModifiedDate_)
		//{
		//	this.ProductCategoryID = ProductCategoryID_;
		//	this.rowguid = rowguid_;
		//	this.ModifiedDate = ModifiedDate_;
		//}
	}
}
