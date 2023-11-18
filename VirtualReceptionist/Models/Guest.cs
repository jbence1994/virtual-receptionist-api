namespace VirtualReceptionist.Models;

public class Guest
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string DocumentId { get; set; }
    public Country Country { get; set; }
    public DateOnly BirthDate { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }
    public Address Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
