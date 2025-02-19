using Bogus;
using Microsoft.EntityFrameworkCore;

namespace GraphQLMinimalAPI.Schema
{
    public class Query
    {
        private readonly ApplicationDbContext _context;

        public Query(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsers() => await _context.Users.ToListAsync();
        public async Task<List<Product>> GetProducts() => await _context.Products.ToListAsync();
        public async Task<List<Order>> GetOrders() => await _context.Orders.ToListAsync();
        public async Task<List<Category>> GetCategories() => await _context.Categories.ToListAsync();
        public async Task<List<Review>> GetReviews() => await _context.Reviews.ToListAsync();
        public async Task<List<Wishlist>> GetWishlists() => await _context.Wishlists.ToListAsync();
        public async Task<List<Coupon>> GetCoupons() => await _context.Coupons.ToListAsync();
        public async Task<List<ShippingDetail>> GetShippingDetails() => await _context.ShippingDetails.ToListAsync();
        public async Task<List<Message>> GetMessages() => await _context.Messages.ToListAsync();


        public async Task<Product?> GetProductById(int id) =>
    await _context.Products.Include(p => p.Category)
                           .Include(p => p.Reviews)
                           .FirstOrDefaultAsync(p => p.Id == id);

    }
}
