using Microsoft.AspNetCore.Mvc;
using WebNTP.Clients;

namespace WebNTP.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        DateTime localNtpTime = NtpClient.GetNetworkTime();
        ViewBag.LocalTime = localNtpTime.ToString("yyyy-MM-dd HH:mm:ss");
        return View();
    }

    public IActionResult TimeZone()
    {
        return View();
    }

    [HttpPost]
    public IActionResult TimeZone(int gmtOffset)
    {
        DateTime ntpTimeUtc = NtpClient.GetNetworkTime().ToUniversalTime();
        DateTime adjusted = ntpTimeUtc.AddHours(gmtOffset);
        ViewBag.GmtOffset = gmtOffset;
        ViewBag.AdjustedTime = adjusted.ToString("yyyy-MM-dd HH:mm:ss");
        return View();
    }
}