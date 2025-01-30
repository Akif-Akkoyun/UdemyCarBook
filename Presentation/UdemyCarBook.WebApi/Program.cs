using UdemyCarBook.Persistence.Context;
using UdemyCarBook.Application.Services;
using UdemyCarBook.WebApi.Hubs;

namespace UdemyCarBook.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.ApplicationServices();

            builder.Services.AddApplicationService(builder.Configuration);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("CorsPolicy");

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.MapHub<CarHub>("/carHub");

            app.Run();
        }
    }
}