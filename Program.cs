using blazor_19c.Data.Models;
using blazor_19c.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SawmillGruszkaDBContext>(options =>
{
    options.UseSqlServer("Data Source=Fra;Initial Catalog=GruszkaDB;Integrated Security=True;TrustServerCertificate=True;");
});
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.TryAddScoped<IWorkerService, WorkerService>();
builder.Services.TryAddScoped<ITaskService, TaskService>();
builder.Services.TryAddScoped<IGroupService, GroupService>();
builder.Services.AddMudServices();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
