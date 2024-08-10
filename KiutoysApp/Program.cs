using Application.Interfaces;
using Application.Interfaces.Services;
using Application.Services;
using Application.UseCases;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers().AddNewtonsoftJson(
        x => 
        x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    );

    builder.Services.AddControllers();

    var connectionString = builder.Configuration.GetConnectionString("KiutoysConnection");
    builder.Services.AddDbContext<KiutoysContext>(options => {
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    });

    builder.Services.AddScoped<IProductRepository, ProductRepository>();
    builder.Services.AddScoped<GetProductByIdUseCase>();
    builder.Services.AddScoped<ListAllProductsUseCase>();
    builder.Services.AddScoped<ListAllAvailableProductsUseCase>();
    builder.Services.AddScoped<AddProductUseCase>();
    builder.Services.AddScoped<DeleteProductUseCase>();
    builder.Services.AddScoped<IProductService, ProductService>();
}

var app = builder.Build(); 
{
    using (var scope = app.Services.CreateScope())
    {
        var context = scope.ServiceProvider.GetRequiredService<KiutoysContext>();
        context.Database.Migrate();
    }

    app.UseHttpsRedirection();

    app.MapControllers();
    app.Run();
}