namespace GraphQLMinimalAPI.Schema;
public class Coupon
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public decimal DiscountAmount { get; set; }
    public DateTime ExpiryDate { get; set; }
    public ICollection<OrderCoupon>? OrderCoupons { get; set; }
}