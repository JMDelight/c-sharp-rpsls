using Nancy;
using rslps.Objects;

namespace rslps
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get ["/"] = _ => View ["index.cshtml"];

      Post ["/result"] = _ =>
      {
        int playerChoice = Request.Form["player-choice"];
        rslpsGame newGame = new rslpsGame(playerChoice);
        return View["result.cshtml", newGame];
      };
    }
  }
}
