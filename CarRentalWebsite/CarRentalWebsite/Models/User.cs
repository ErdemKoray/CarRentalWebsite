namespace CarRentalWebsite.Models
{
    public class User{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime LicanseIssueDate { get; set; }
        public string LicanseNumber { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

}   
}