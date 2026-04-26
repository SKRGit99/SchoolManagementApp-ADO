
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Add services to the container.
builder.Services.AddControllersWithViews();
// Source - https://stackoverflow.com/a
// Posted by Kirk Larkin, modified by community. See post 'Timeline' for change history
// Retrieved 2025-11-29, License - CC BY-SA 4.0

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
//app.MapRazorPages()
//   .WithStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    //pattern: "{controller=Student}/{action=GetStudentDetails}/{id?}")
    //pattern: "{controller=Student}/{action=GetIndividualStudentDetailsByRegistrationId}/{id?}")
    //pattern: "{controller=Educator}/{action=GetEducatorDetails}/{id?}")
    //pattern: "{controller=Student}/{action=GetIndividualStudentDetailsByRegistrationId}/{id?}")
    //pattern: "{controller=Student}/{action=displayOrganisationDetails}/{id?}")
    .WithStaticAssets();

app.Run();
