using DemoMVCFW.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddTransient<IStudent, studentImpl>();
builder.Services.AddTransient<DummyClass>();

var app = builder.Build();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "StudentId",
    pattern: "StudentDetails/{id :int}",
    defaults: new { controller = "Student", action = "Details" });



app.MapControllerRoute(
    name: "StudentAll",
    pattern: "Student/All",
    defaults: new { controller = "Student", action = "Index" });


app.Run();
