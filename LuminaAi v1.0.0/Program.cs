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

// Enable Static File serving for CSS, JS, Images, etc.
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Maps Razor Pages to the routing system.
app.MapRazorPages();

// Ensure Static Assets are mapped correctly.
app.MapStaticAssets(); // Ensure this maps static assets correctly.

app.Run();
