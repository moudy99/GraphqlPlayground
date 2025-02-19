namespace GraphQLMinimalAPI.Schema;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string Role { get; set; } = "Buyer";
    public ICollection<Order>? Orders { get; set; }
    public ICollection<Product>? Products { get; set; }
    public ICollection<Review>? Reviews { get; set; }
    public ICollection<Wishlist>? Wishlists { get; set; }
}