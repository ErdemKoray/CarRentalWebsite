namespace CarRentalWebsite.Models{
    public class Payment{
    public int Id { get; set; }
    public int RentalId { get; set; }  // Kiralama işlemi ile ilişkili
    public DateTime PaymentDate { get; set; }  // Ödeme Tarihi
    public decimal Amount { get; set; }  // Ödeme Tutarı
    public string PaymentMethod { get; set; }  // Ödeme Yöntemi (Kredi Kartı, Nakit, vs.)
  }
}