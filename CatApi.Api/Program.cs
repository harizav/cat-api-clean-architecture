using CatApi.Application.Interfaces;
using CatApi.Application.Services;
using CatApi.Infrastructure.ExternalApis;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// HttpClient para TheCatAPI
builder.Services.AddHttpClient<ICatApiClient, CatApiClient>(client =>
{
    client.BaseAddress = new Uri("https://api.thecatapi.com/v1/");
    client.DefaultRequestHeaders.Add("x-api-key", 
        builder.Configuration["CatApi:ApiKey"]);
});

// DI - Application
builder.Services.AddScoped<ICatService, CatService>();
builder.Services.AddScoped<IImageService, ImageService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
