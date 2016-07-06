using System;

namespace rslps.Objects
{
  public class rslpsGame
  {
    private static string [] gameOptions = new string [5] {"Rock", "Scissors", "Lizard", "Paper", "Spock"};
    private int _choiceOne;
    private int _choiceTwo;
    private int _difference;
    private static int _playerOneScore = 0;
    private static int _playerTwoScore = 0;

    public rslpsGame(int choiceOne, int choiceTwo = -1)
    {
      _choiceOne = choiceOne;
      if (choiceTwo==-1) _choiceTwo = rslpsRandom();
      else _choiceTwo = choiceTwo;
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

    public int GetPlayerOneScore()
    {
      return _playerOneScore;
    }

    public int GetPlayerTwoScore()
    {
      return _playerTwoScore;
    }

    public string rslpsFight()
    {
      string result;

      if (_difference % 5 == 4 || _difference % 5 == 3) {
        result = "Player One Wins";
        _playerOneScore++;
      }
      else if (_difference % 5 == 1 || _difference % 5 == 2){
        result = "Player Two Wins";
        _playerTwoScore++;
      }
      else if (_choiceOne == _choiceTwo) result = "Tie";
      else result = "Error!";
      return result;
    }

    public int rslpsRandom()
    {
      Random random = new Random();
      return random.Next(0,5);
    }
    public string rslpsImageNamer(string choiceName)
    {
      string returnValue = "Content/img/";
      returnValue += choiceName;
      returnValue += ".png";
      return returnValue;
    }
  }
}
