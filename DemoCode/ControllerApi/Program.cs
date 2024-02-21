using People.Library;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IPeopleProvider, HardCodedPeopleProvider>();

builder.Services.AddControllers();

// Set JSON indentation
// Does not do anything for controller APIs
builder.Services.ConfigureHttpJsonOptions(options => options.SerializerOptions.WriteIndented = true);

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
