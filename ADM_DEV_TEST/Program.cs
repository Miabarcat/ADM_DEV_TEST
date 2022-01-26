using ADM_DEV_TEST.DL.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<ITest1Service, Test1Service>();
builder.Services.AddSingleton<ITest2Service, Test2Service>();
builder.Services.AddSingleton<ITest3Service, Test3Service>();
builder.Services.AddSingleton<ITest4Service, Test4Service>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
