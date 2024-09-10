using System.ComponentModel.DataAnnotations;

namespace Database.Learning.DbModels
{
    public class Product
    {
        public int ProductID { get; set; }

        [MaxLength(50)]
        public required string ProductName { get; set; }

        public int SupplierID { get; set; }

        public Supplier Supplier { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }

        [MaxLength(50)]
        public required string Unit { get; set; }

        public double Price { get; set; }
    }
}
