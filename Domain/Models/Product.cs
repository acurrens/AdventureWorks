using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product
    {
		public int ProductID { get; set; }
		public string ProductNumber { get; set; }
		public string Color { get; set; }
		public short SafetyStockLevel { get; set; }
		public short ReorderPoint { get; set; }
		public decimal StandardCost { get; set; }
		public decimal ListPrice { get; set; }
		public string Size { get; set; }
		public string SizeUnitMeasureCode { get; set; }
		public string WeightUnitMeasureCode { get; set; }
		public decimal Weight { get; set; }
		public int DaysToManufacture { get; set; }
		public string ProductLine { get; set; }
		public string Class { get; set; }
		public string Style { get; set; }
		public int ProductSubcategoryID { get; set; }
		public int ProductModelID { get; set; }
		public DateTime SellStartDate { get; set; }
		public DateTime SellEndDate { get; set; }
		public DateTime DiscontinuedDate { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		//public Product(int ProductID_, string ProductNumber_, string Color_, short SafetyStockLevel_, short ReorderPoint_, decimal StandardCost_, decimal ListPrice_, string Size_, string SizeUnitMeasureCode_, string WeightUnitMeasureCode_, decimal Weight_, int DaysToManufacture_, string ProductLine_, string Class_, string Style_, int ProductSubcategoryID_, int ProductModelID_, DateTime SellStartDate_, DateTime SellEndDate_, DateTime DiscontinuedDate_, Guid rowguid_, DateTime ModifiedDate_)
		//{
		//	this.ProductID = ProductID_;
		//	this.ProductNumber = ProductNumber_;
		//	this.Color = Color_;
		//	this.SafetyStockLevel = SafetyStockLevel_;
		//	this.ReorderPoint = ReorderPoint_;
		//	this.StandardCost = StandardCost_;
		//	this.ListPrice = ListPrice_;
		//	this.Size = Size_;
		//	this.SizeUnitMeasureCode = SizeUnitMeasureCode_;
		//	this.WeightUnitMeasureCode = WeightUnitMeasureCode_;
		//	this.Weight = Weight_;
		//	this.DaysToManufacture = DaysToManufacture_;
		//	this.ProductLine = ProductLine_;
		//	this.Class = Class_;
		//	this.Style = Style_;
		//	this.ProductSubcategoryID = ProductSubcategoryID_;
		//	this.ProductModelID = ProductModelID_;
		//	this.SellStartDate = SellStartDate_;
		//	this.SellEndDate = SellEndDate_;
		//	this.DiscontinuedDate = DiscontinuedDate_;
		//	this.rowguid = rowguid_;
		//	this.ModifiedDate = ModifiedDate_;
		//}
	}
}
