global using Microsoft.EntityFrameworkCore;
global using WebApplication3.DBContext;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using NETCore.MailKit.Core;
using System.Text;
using System.Text.Json.Serialization;
using WebApplication3.Repository.Abastract;
using WebApplication3.Repository.Implementaion;
using ProductMiniApi.Repository.Implementation;
using WebApplication3.Models.Repository.Abastract;
using WebApplication3.Models.Repository.Implementaion;
using WebApplication3.UtilityService;
using PdfSharp.Charting;
using WebApplication3.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<DataContext>(options =>

{

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});
builder.Services.AddSignalR();


builder.Services.AddCors(opt =>

{
    opt.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod();
       
    }

        );

}

);





builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("verryySercrtttttttttttttttttttttttttttetee")),
    ValidateAudience = false,
    ValidateIssuer = false
    };

});














builder.Services.AddTransient<IFileService, FileService>();
builder.Services.AddTransient<IProductRepository, ProductRepostory>();


//builder.Services.AddTransient<ICategoryRepository, CategoryRepository>(); //resolving our dependencies
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();


//builder.Services.AddScoped<WebApplication3.UtilityService.IEmailService, EmailService>();
//builder.Services.AddScoped<WebApplication3.UtilityService.IEmailService, EmailService>();
//builder.Services.AddTransient<IResumeService, ResumeService>();

builder.Services.AddScoped<IEMAILlservice, EMAILlservicecs>();



builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);





var app = builder.Build();


app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "Uploads")),
    RequestPath = "/Resources"
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}











app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseCors("CorsPolicy");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapHub<ChatHub>("/chatsocket");

});
//app.MapControllers();

app.Run();



