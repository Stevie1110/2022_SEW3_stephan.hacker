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
app.UseStaticFiles();           //damit Seite funktioniert

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints => { endpoints.MapGet("/name", () => "Thomas Riegler"); });
app.MapRazorPages();

app.Run();
