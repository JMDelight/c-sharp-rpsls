using System;

namespace rslps.Objects
{
  public class rslpsGame
  {
    private static string [] gameOptions = new string [5] {"Rock", "Scissors", "Lizard", "Paper", "Spock"};
    private int _choiceOne;
    private int _choiceTwo;

    public rslpsGame(int choiceOne)
    {
      _choiceOne = choiceOne;
      _choiceTwo = rslpsRandom();
    }

    public rslpsGame(int choiceOne, int choiceTwo)
    {
      _choiceOne = choiceOne;
      _choiceTwo = choiceTwo;
    }

    public string GetChoiceOne()
    {
      return gameOptions[_choiceOne];
    }

    public string GetChoiceTwo()
    {
      return gameOptions[_choiceTwo];
    }

    public string rslpsFight()
    {
      string result;
      if (_choiceOne-_choiceTwo == -1 || _choiceOne-_choiceTwo == -2 || _choiceOne-_choiceTwo == 4 || _choiceOne-_choiceTwo == 3) result = "Player One Wins";
      else if (_choiceOne-_choiceTwo == 1 || _choiceOne-_choiceTwo == 2 || _choiceOne-_choiceTwo == -4 || _choiceOne-_choiceTwo == -3) result = "Player Two Wins";
      else if (_choiceOne == _choiceTwo) result = "Tie";
      else result = "Error!";
      return result;
    }

    public int rslpsRandom()
    {
      Random random = new Random();
      return random.Next(0,5);
    }
  }
}
