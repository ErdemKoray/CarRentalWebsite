namespace CarRentalWebsite.Models{
    public class Reservation{
    public int Id { get; set; }
    public int CarId { get; set; }
    public int CustomerId { get; set; }
    public DateTime ReservationDate { get; set; }  // Rezervasyon Tarihi
    public DateTime PickupDate { get; set; }       // Aracın Alınacağı Tarih
    public DateTime ReturnDate { get; set; }       // Aracın Teslim Edileceği Tarih
    public bool IsConfirmed { get; set; }  // Rezervasyon Onay Durumu


    }
}