using System.ComponentModel.DataAnnotations;

namespace Database.Learning.DbModels
{
    public class Category
    {
        public int CategoryID { get; set; }

        [MaxLength(50)]
        public required string CategoryName { get; set; }

        [MaxLength(200)]
        public required string Description { get; set; }
    }
}
