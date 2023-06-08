using Microsoft.EntityFrameworkCore;
using Pokemon.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

builder.Services.AddDbContext<MisDatos>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MiDataBase") ?? throw new InvalidOperationException
    ("Connection string 'MiDataBase' not found.")));

var app = builder.Build();

app.MapRazorPages();
app.UseStaticFiles();
app.Run();
