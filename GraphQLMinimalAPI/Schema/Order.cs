namespace GraphQLMinimalAPI.Schema;
public class Order
{
    public int Id { get; set; }
    public int BuyerId { get; set; }
    public User? Buyer { get; set; }
    public decimal TotalPrice { get; set; }
    public string Status { get; set; } = "Pending";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<OrderItem>? OrderItems { get; set; }
    public Payment? Payment { get; set; }
    public ShippingDetail? ShippingDetail { get; set; }
    public ICollection<OrderCoupon>? OrderCoupons { get; set; }
}