using BeautySalon.Web.Data;
using BeautySalon.Web.Services;
using Microsoft.EntityFrameworkCore; // Необходимо для UseNpgsql

var builder = WebApplication.CreateBuilder(args);


// Подключение MVC (Контроллеры и Представления)
builder.Services.AddControllersWithViews();

// Подключение базы данных PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Регистрация вашего сервиса бизнес-логики
builder.Services.AddScoped<ISalonService, SalonService>();

var app = builder.Build();


// Обработка ошибок (включается только в Production)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// Обязательно для загрузки css, js, картинок, логотипа из папки wwwroot
app.UseStaticFiles();

// Маршрутизация запросов
app.UseRouting();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();