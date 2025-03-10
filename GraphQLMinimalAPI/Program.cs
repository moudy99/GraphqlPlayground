
using GraphQLMinimalAPI.Schema;
using Microsoft.EntityFrameworkCore;

namespace GraphQLMinimalAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                    b=>b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Here add graphql server
            builder.Services.AddGraphQLServer()
                .AddQueryType<Query>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapGraphQL("/graphql");


            app.MapGet("test", () => "TEST");
            app.Run();
        }
    }
}
