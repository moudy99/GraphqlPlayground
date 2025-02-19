namespace GraphQLMinimalAPI.Schema;
public class ShippingDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public Order? Order { get; set; }
    public string Address { get; set; } = string.Empty;
    public string? TrackingNumber { get; set; }
    public string Status { get; set; } = "Processing";
}