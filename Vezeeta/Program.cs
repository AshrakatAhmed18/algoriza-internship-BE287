



using DomainLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using RepositoryLayer.Repository.AdminRepository.DashboardRepository;
using RepositoryLayer.Repository.AdminRepository.DoctorRepository;
using RepositoryLayer.Repository.AdminRepository.PatientRepository;
using RepositoryLayer.Repository.AdminRepository.SettigRepository;
using RepositoryLayer.Repository.AdminRepository.SettingRepository;
using RepositoryLayer.Repository.PatientRepository.PatientBookingRepository;
using RepositoryLayer.Repository.PatientRepository.PatientDoctorRepository;
using ServiceLayer.AdminService.DashboardService;
using ServiceLayer.AdminService.DoctorServices;
using ServiceLayer.AdminService.PatientService;
using ServiceLayer.PatientService.PatientBookingService;
using ServiceLayer.PatientService.PatientDoctorService;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
var ConnString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                                 throw new InvalidOperationException("Can`t Find This connection String");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ConnString));
builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>().AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped<IAdminDoctorService, AdminDoctorService>();
builder.Services.AddScoped<IAdminDoctorRepository, AdminDoctorRepository>();

builder.Services.AddScoped<IAdminPatientService, AdminPatientService>();
builder.Services.AddScoped<IAdminPatientRepository, AdminPatientRepository>();


builder.Services.AddScoped<IAdminSettingService, AdminSettingService>();
builder.Services.AddScoped<IAdminSettingRepository, AdminSettingRepository>();

builder.Services.AddScoped<IAdminDashboardRepository, AdminDashboardRepository>();
builder.Services.AddScoped<IAdminDashboardService , AdminDashboardService>();


builder.Services.AddScoped<IPatientDoctorRepository, PatientDoctorRepository>();
builder.Services.AddScoped<PatientDoctorService>();

builder.Services.AddScoped<IPatientBookingRepository, PatientBookingRepository>();
builder.Services.AddScoped<PatientBookingService>();








var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
