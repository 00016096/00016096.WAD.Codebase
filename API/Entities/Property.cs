namespace Realestate.Entities;

public class RealEstateProperty
{
    public int Id { get; set; }
    public string? Address { get; set; }
    public decimal Price { get; set; }

    public int AgentId { get; set; }
}