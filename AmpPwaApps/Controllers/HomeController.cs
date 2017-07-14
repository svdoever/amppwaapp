// Decompiled with JetBrains decompiler
// Type: AmpPwaApps.Controllers.HomeController
// Assembly: AmpPwaApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B83A9E8A-0CC6-4EF0-B265-B633C3C6E5B5
// Assembly location: C:\P\amp-oever\AmpPwaApps.dll

using Microsoft.AspNetCore.Mvc;

namespace AmpPwaApps.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return (IActionResult) this.View();
    }

    public IActionResult About()
    {
      this.ViewData["Message"] = (object) "Your application description page!.";
      return (IActionResult) this.View();
    }

    public IActionResult Contact()
    {
      this.ViewData["Message"] = (object) "Your contact page.";
      return (IActionResult) this.View();
    }

    public IActionResult Error()
    {
      return (IActionResult) this.View();
    }
  }
}
