using Microsoft.EntityFrameworkCore;
using Eleaning_Web.Model;
using Eleaning_Web.Interface;
using Eleaning_Web.Repository;
using Eleaning_Web.Services;
using Eleaning_Web;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));


builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IUser, UserManager>();
builder.Services.AddScoped<IAnswer, AnswerRepository>();
builder.Services.AddScoped<IClass, ClassRepository>();
builder.Services.AddScoped<IContentTest, ContentTestRepository>();
builder.Services.AddScoped<IDocument, DocumentRepository>();
builder.Services.AddScoped<IExam, ExamRepository>();
builder.Services.AddScoped<ILearningResult, LearningResultRepository>();
builder.Services.AddScoped<ISchedule, ScheduleRepository>();
builder.Services.AddScoped<ITest, TestRepository>();
builder.Services.AddScoped<ISubject, SubjectRepository>();
builder.Services.AddScoped<ITestSchedule, TestScheduleRepository>();

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