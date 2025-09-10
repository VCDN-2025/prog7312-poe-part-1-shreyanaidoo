using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.Run();

//<!-- Referencing -->
//<!--Microsoft Learn, 2025. LinkedList<T> Class [Online]. Available at:<https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-9.0> [Acessed on 01 September 2025]-->
//<!--wheretostay,2020. Durban Beachfront Accommodation[Electronic Print]. Available at:<https://www.wheretostay.co.za/town/durban-beachfront-cbd/accommodation> [Acessed on 05 September 2025]-->
//<!--IStock,2019. Durban Beachfront [Electronic Print]. Available at:<https://www.istockphoto.com/search/2/image-film?phrase=durban+beach> [Acessed on 05 September 2025]-->
//<!--Facebook, 2012. EThekwini Municipality [Electronic Print]. Available at:<https://www.facebook.com/eThekwiniM/> [Acessed on 05 September 2025]--><!-- Referencing -->
