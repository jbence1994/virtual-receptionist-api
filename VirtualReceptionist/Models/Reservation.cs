namespace VirtualReceptionist.Models;

public class Reservation
{
    public int Id { get; set; }
    public Guest Guest { get; set; }
    public Room Room { get; set; }
    public int HeadCount { get; set; }
    public DateOnly ArrivalDate { get; set; }

    public DateOnly DepartureDate => ArrivalDate.AddDays(NumberOfNights);

    public int NumberOfNights { get; set; }
    public bool IsPaid { get; set; }
}
