namespace rslps.Objects
{
  public class rslpsGame
  {
    private static string [] gameOptions = new string [5] {"Rock", "Scissors", "Lizard", "Paper", "Spock"};
    public string rslpsFight(int choiceOne, int choiceTwo)
    {
      string result;
      if (choiceOne-choiceTwo == 1 || choiceOne-choiceTwo == 2) result = "Player One Wins";

      else result = "Tie";
      return result;
    }
  }
}
