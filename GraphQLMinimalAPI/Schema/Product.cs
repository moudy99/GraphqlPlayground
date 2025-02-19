namespace GraphQLMinimalAPI.Schema;
public class Product
{
    public int Id { get; set; }
    public int SellerId { get; set; }
    public User? Seller { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<OrderItem>? OrderItems { get; set; }
    public ICollection<Review>? Reviews { get; set; }
    public ICollection<Wishlist>? Wishlists { get; set; }
}