using System.ComponentModel.DataAnnotations;

namespace Database.Learning.DbModels
{
    public class Shipper
    {
        public int ShipperID { get; set; }

        [MaxLength(50)]
        public required string ShipperName { get; set; }

        [MaxLength(20)]
        public required string Phone { get; set; }
    }
}
