namespace VirtualReceptionist.Models;

public class BillingItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public BillingCategory Category { get; set; }
}
