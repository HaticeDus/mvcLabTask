
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();


//app.MapControllerRoute(
// name: "default",
// pattern: "{controller=}/{action=Index}/{id?}");//[Controller] /[ActionName] /[Parameters]

//--------------------------------------------------------------------------------------

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=EmployeeController}/{action=Index}/{id?}");

    endpoints.MapRazorPages();
});


//--------------------------------------------------------------------


//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "employeeDetails",
//        pattern: "Employee/Details/{id}", // Route þablonu burada belirlenir
//        defaults: new { controller = "Employee", action = "Details" } // Controller ve action isimleri belirlenir
//    );

//    // Diðer endpoint ayarlarý burada...

//    endpoints.MapRazorPages();
//});


app.Run();
