using System.ComponentModel.DataAnnotations;

namespace Database.Learning.DbModels
{
    public class Order
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public int ShipperID { get; set; }
        public Shipper Shipper { get; set; }
    }
}
