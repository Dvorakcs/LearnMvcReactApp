using LearnMvcReactApp.Server.Dados;
using LearnMvcReactApp.Server.Models;
using LearnMvcReactApp.Server.Repositories.IRepositories;
using LearnMvcReactApp.Server.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Registra o repositório genérico para IGenericsRepository<Produtos>
builder.Services.AddScoped(typeof(IGenericsRepository<>), typeof(GenericsRepository<>));

// Registra a implementação específica para IGenericsRepository<Produtos>
builder.Services.AddScoped<IProdutosRepository, ProdutosRepository>();

var app = builder.Build();

ConfigureApp(app);

void ConfigureApp(WebApplication app)
{
    app.UseDefaultFiles();
    app.UseStaticFiles();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.MapFallbackToFile("/index.html");
}

app.Run();
