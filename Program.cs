using App.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// builder.Services.AddSingleton<ProductService>();
// builder.Services.AddSingleton<ProductService, ProductService>();
// builder.Services.AddSingleton(typeof(ProductService));
builder.Services.AddSingleton(typeof(ProductService), typeof(ProductService));

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

app.UseAuthentication();    // Xac dinh danh tinh
app.UseAuthorization();     // Xac thuc quyen truy cap

app.UseAuthorization();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");


// Explain rooting
    // This code will create an endpoint as create roots named "default"
    // It will analyze access address URL
    // if have URL: /{controller}/{action}/{id?}
    // then initial a controller by [controller name] and then redirect request to controller
    // and execute the {action} method
    // ---- Example ------------------
    // Access URL: Abc/Xyz
    // System will analyze to find the Controller name is [Abc] and initial it
    // After initial this controller and setting properties in controller
    // It will call [Xyz] method in this controller
app.UseEndpoints(endpoints => 
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapRazorPages();
});

app.Run();
