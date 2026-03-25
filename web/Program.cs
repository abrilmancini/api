using Application.Servicies;

var builder = WebApplication.CreateBuilder(args);

// Servicios
builder.Services.AddControllers();

#region Injecting Services
builder.Services.AddScoped<UserService>();
#endregion

var app = builder.Build();

// Middleware
app.UseHttpsRedirection();


app.MapControllers();

app.Run();