using CompanyAnalysisApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddXmlFile("company.xml", optional: false, reloadOnChange: true)
    .AddIniFile("company.ini", optional: false, reloadOnChange: true)
    .AddJsonFile("myDate.json", optional: false, reloadOnChange: true);


builder.Services.AddControllersWithViews();
builder.Services.AddTransient<CompanyAnalyzerService>(); // Реєструємо сервіс



var app = builder.Build();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
