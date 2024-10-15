namespace CarRentalWebsite.Models{
public class User{
    public int Id { get; set; }
    public string Username { get; set; }  // Kullanıcı Adı
    public string Password { get; set; }  // Şifre (Hashlenmiş olmalı)
    public string Role { get; set; }  // Rol (Admin, Customer vs.)
}
}