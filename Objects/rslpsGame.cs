using System;

namespace rslps.Objects
{
  public class rslpsGame
  {
    private static string [] gameOptions = new string [5] {"Rock", "Scissors", "Lizard", "Paper", "Spock"};
    private int _choiceOne;
    private int _choiceTwo;
    private int _difference;

    public rslpsGame(int choiceOne, int choiceTwo = -1)
    {
      _choiceOne = choiceOne;
      if (choiceTwo==-1) _choiceTwo = rslpsRandom();
      else _choiceTwo = choiceTwo;
      Console.WriteLine("1:"+_choiceOne+"2:"+_choiceTwo);
      // -- adding 5 to the difference to allow % to work with negative numbers as if they were an extension of positive numbers -- //
      _difference = 5 + _choiceOne - _choiceTwo;
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

      if (_difference % 5 == 4 || _difference % 5 == 3) result = "Player One Wins";
      else if (_difference % 5 == 1 || _difference % 5 == 2) result = "Player Two Wins";
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
