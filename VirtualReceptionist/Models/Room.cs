namespace VirtualReceptionist.Models;

public class Room
{
    public int Id { get; set; }
    public int Number { get; set; }
    public int Capacity { get; set; }
    public BillingItem BillingItem { get; set; }
}
