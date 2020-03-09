using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index(string noun1, string noun2, string noun3, string nounPlural, string place, string adjective)
    {
      Story myStory = new Story();
      myStory.Noun1 = noun1;
      myStory.Noun2 = noun2;
      myStory.Noun3 = noun3;
      myStory.NounPlural = nounPlural;
      myStory.Place = place;
      myStory.Adjective = adjective;
      return View(myStory);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}