using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using MudBlazor.Services;
using MudTrain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudTrain.Models;
using static MudTrain.Pages.Issuing_tickets;

internal class Program
{
    private static string? b;

    private static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);



        StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        //builder.Services.AddSingleton<TrainsBDService>();

        b = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<TicketContext>(options =>
                        options.UseSqlServer(b));
        builder.Services.AddMudServices();
        //builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

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
    }
}
