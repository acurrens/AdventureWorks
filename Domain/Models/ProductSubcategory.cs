using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductSubcategory
    {
		public int ProductSubcategoryID { get; set; }
		public int ProductCategoryID { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		//public ProductSubcategory(int ProductSubcategoryID_, int ProductCategoryID_, Guid rowguid_, DateTime ModifiedDate_)
		//{
		//	this.ProductSubcategoryID = ProductSubcategoryID_;
		//	this.ProductCategoryID = ProductCategoryID_;
		//	this.rowguid = rowguid_;
		//	this.ModifiedDate = ModifiedDate_;
		//}
	}
}
