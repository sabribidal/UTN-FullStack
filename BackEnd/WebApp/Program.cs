using WebApp.EjemploInyeccionDep;
using WebApp.Repositories;

var builder = WebApp.CreateBuilder(args); 


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IEmailService, EmailService>();

builder.Services.AddScoped<UsuarioService>();

builder.Services.AddSingleton<InstrumentRepository>();

var app = builder.Build(); 

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization(); 

app.MapControllers();  

app.Run();