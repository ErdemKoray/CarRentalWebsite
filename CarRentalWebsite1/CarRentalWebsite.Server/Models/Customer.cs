namespace CarRentalWebsite.Models
{
    public class Customer{
        public int Id {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Email {get;set;}
        public string PhoneNumber{get;set;}
        public string Address{get;set;}
        public string Country{get;set;}
        public DateTime MembershipDate {get;set;}=DateTime.UtcNow;
        





    }
}