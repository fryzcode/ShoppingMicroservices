var builder = WebApplication.CreateBuilder(args);
//Add services to the container
var app = builder.Build();

// conf http req pipeline

app.Run();