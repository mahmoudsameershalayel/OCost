using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using NLog;
using OCoast.API.Infrastructure.Helpers;
using OCoast.API.Infrastructure.Services.ApplicationUserServices;
using OCoast.API.Infrastructure.Services.TokenServices;
using OCoast.Data;
using OCoast.Data.DBEntities;
using OCost.API.Infrastructure.Middleware;
using OCost.API.Infrastructure.Repositories;
using OCost.API.Infrastructure.Services.LoggerService;
using OCost.Service;
using OCost.Service.Contracts;
using System.Globalization;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

//connect to database 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(connectionString)
);

//configure logging
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),
"/nlog.config"));

builder.Services.AddControllers(config =>
{
    config.RespectBrowserAcceptHeader = true;
}).AddXmlDataContractSerializerFormatters();


builder.Services.AddAuthentication(options =>
{
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;

}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("Token:TokenKey").Value)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

//Add Identity Application User
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredUniqueChars = 1;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 1;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.SignIn.RequireConfirmedAccount = false;
}).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();


//dependency injection
builder.Services.AddScoped<ITokenService, TokenService>();


//Register repository & service manager
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IServiceManager, ServiceManager>();


//Register logger service
builder.Services.AddSingleton<ILoggerManager, LoggerManager>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Add Auto Mapper Service
builder.Services.AddAutoMapper(typeof(ApplicationProfile).Assembly);
var app = builder.Build();

var logger = app.Services.GetRequiredService<ILoggerManager>();

//Customize exception handling middleware
app.UseMiddleware<ExceptionMiddleware>();



//Support localization
var supportedCultures = new List<CultureInfo> { new("en-US"), new("ar-SA") };
app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("en-US"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
});


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
