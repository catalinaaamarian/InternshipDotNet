var builder = WebApplication.CreateBuilder(args);

// 🔧 Adaugă suport pentru controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// 🟢 Asta mapează toate controlerele tale, inclusiv BooksController
app.MapControllers();

app.Run();
