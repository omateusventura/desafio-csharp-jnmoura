
using API.Infra.Database;
using API.Infra.Repositories;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace api_jnmoura
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddCors(options => options.AddPolicy(name: "MyAllowSpecificOrigins", policy =>
                policy.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            ));

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddRouting(options => options.LowercaseUrls = true);
            builder.Services.AddDbContext<DatabaseContext>(options =>
            {
                var conn = builder.Configuration.GetConnectionString("Database");
                options.UseMySql(conn, ServerVersion.AutoDetect(conn));
            });
            builder.Services.AddScoped<IPeopleRepository, PeopleRepositoryDatabase>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.UseCors("MyAllowSpecificOrigins");
            app.Run();
        }
    }
}
