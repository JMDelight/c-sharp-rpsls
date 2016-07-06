namespace rslps.Objects
{
  public class rslpsGame
  {
    private static string [] gameOptions = new string [5] {"Rock", "Scissors", "Lizard", "Paper", "Spock"};
    public string rslpsFight(int choiceOne, int choiceTwo)
    {
      string result;
      if (choiceOne-choiceTwo == 1 || choiceOne-choiceTwo == 2 || choiceOne-choiceTwo == 4 || choiceOne-choiceTwo == 3) result = "Player One Wins";
      else if (choiceOne-choiceTwo == -1 || choiceOne-choiceTwo == -2 || choiceOne-choiceTwo == -4 || choiceOne-choiceTwo == -3) result = "Player Two Wins";
      else if (choiceOne == choiceTwo) result = "Tie";
      else result = "Error!";
      return result;
    }
  }
}
