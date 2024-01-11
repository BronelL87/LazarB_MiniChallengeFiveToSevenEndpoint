using LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL;
using LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL.OddOrEven;
using LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL.ReverseAlph;
using LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL.ReverseNum;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibServices, MadLibService>();
builder.Services.AddScoped<IOddOrEvenServices, OddOrEvenService>();
builder.Services.AddScoped<IReverseAlphServices, ReverseAlphService>();
builder.Services.AddScoped<IReverseNumServices, ReverseNumService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
