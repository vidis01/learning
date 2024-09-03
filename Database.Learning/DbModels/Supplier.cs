using System.ComponentModel.DataAnnotations;

namespace Database.Learning.DbModels
{
    public class Supplier
    {
        public int SupplierID { get; set; }

        [MaxLength(50)]
        public required string SupplierName { get; set; }

        [MaxLength(50)]
        public required string ContactName { get; set; }

        [MaxLength(50)]
        public required string Address { get; set; }

        [MaxLength(50)]
        public required string City { get; set; }

        [MaxLength(20)]
        public required string PostalCode { get; set; }

        [MaxLength(50)]
        public required string Country { get; set; }

        [MaxLength(20)]
        public required string Phone { get; set; }         
    }
}
