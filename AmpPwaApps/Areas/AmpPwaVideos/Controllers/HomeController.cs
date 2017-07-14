using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Reflection;

namespace AmpPwaApps.Areas.AmpPwaVideos.Controllers
{
  public class HomeController : Controller
  {
    [Area("AmpPwaVideos")]
    public IActionResult Index()
    {
      string path1 = Path.Combine(new FileInfo(new Uri(Assembly.GetEntryAssembly().CodeBase).AbsolutePath).Directory.FullName, "data\\AmpPwaVideos\\amp-conf-2017");
      string path2_1 = "amp-conf-2017-Agenda.yaml";
      string agendaYaml = System.IO.File.ReadAllText(Path.Combine(path1, path2_1));
      string path2_2 = "amp-conf-2017-Speakers.yaml";
      string speakersYaml = System.IO.File.ReadAllText(Path.Combine(path1, path2_2));
      return (IActionResult) this.View((object) DeserializeYaml.GetConference(agendaYaml, speakersYaml));
    }
  }
}
