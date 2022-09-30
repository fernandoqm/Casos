using apicasos.ConfigApi;
using DataAccess.Repository;
using Microsoft.Net.Http.Headers;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:5118",
                               "https://localhost:5118")
                   .AllowAnyMethod()
                   .AllowAnyHeader()
                   .AllowAnyMethod()
                   .WithHeaders(HeaderNames.ContentType);
        }
        );
});



// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICasosRepository, casosRepository>();
builder.Services.AddSingleton<ITegnologiaRepository, tegnologiaRepository>();
builder.Services.AddSingleton<IUsuariosRepository, UsuariosRepository>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




app.UseHttpsRedirection();
app.UseCors();
app.ConfigureApiCasos();
app.ConfigureApiTegnologia();
app.ConfigureApiUsuarios();
app.Run();

