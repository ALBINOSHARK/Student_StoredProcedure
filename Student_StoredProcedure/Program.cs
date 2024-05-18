using Core.Interface;
using Student_Repository;
using Student_Repository.Common;
using StudentService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<Helper>();
builder.Services.AddSingleton<IRepository,Repository>();
builder.Services.AddSingleton<IService,Service>();
//builder.Services.AddDbContext<StudentStoredProcedureContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CompanyConnStr")));

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
