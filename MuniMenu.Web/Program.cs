using MuniMenu.Adapters.ThirdParty.Extensions;
using MuniMenu.Web.BackgroundServices;
using MuniMenu.Web.Hubs;
using MuniMenu.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRestaurants();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSingleton<IRestaurantFacade, RestaurantFacade>();
builder.Services.AddHostedService<LoadRestaurantsBackgroundService>();

builder.Services.AddApplicationInsightsTelemetry();
builder.Services.AddSignalR();

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

app.MapHub<VoteHub>("/voteHub");

app.Run();
