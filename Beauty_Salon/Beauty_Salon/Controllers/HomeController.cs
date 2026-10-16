using BeautySalon.Web.Services;
using BeautySalon.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BeautySalon.Web.Controllers;

public class HomeController : Controller
{
    private readonly ISalonService _salonService;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ISalonService salonService, ILogger<HomeController> logger)
    {
        _salonService = salonService;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var vm = new HomeIndexViewModel();

        try
        {
            vm.Settings = await _salonService.GetSettingsAsync();
            vm.Schedules = await _salonService.GetSchedulesAsync();
            vm.Masters = await _salonService.GetMastersAsync();
            vm.Services = await _salonService.GetServicesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка загрузки главной страницы");
            vm.ErrorMessage = "Не удалось загрузить данные. Попробуйте позже.";
        }

        return View(vm);
    }
}