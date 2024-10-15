namespace CarRentalWebsite.Models{
public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; }  // Marka (Ör: Toyota, BMW)
    public string Model { get; set; }  // Model (Ör: Corolla, 320i)
    public string LicensePlate {get;set;}
    public int Year { get; set; }      // Üretim Yılı
    public string FuelType { get; set; }  // Yakıt Türü (Ör: Benzin, Dizel, Elektrik)
    public string Transmission { get; set; }  // Vites Türü (Manuel, Otomatik)
    public decimal DailyPrice { get; set; }  // Günlük Kiralama Ücreti
    public bool IsAvailable { get; set; }  // Kiralamaya Müsait mi?

    public string Description { get; set; }
    
}
}