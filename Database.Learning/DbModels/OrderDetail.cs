namespace Database.Learning.DbModels
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }

        public int OrderID { get; set; }
        public required Order Order { get; set; }

        public int ProductID { get; set; }
        public required Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
