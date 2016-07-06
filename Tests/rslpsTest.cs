using Xunit;
namespace rslps.Objects
{
  public class rslpsTest
  {
    [Fact]
    public void rslpsFight_RockRock_Tie()
    {
      // Arrange
      string expectedResult = "Tie";
      rslpsGame testGame = new rslpsGame(0,0);
      //Act
      string result = testGame.rslpsFight();
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_ScissorsRock_PlayerOneWins()
    {
      //Arrange
      string expectedResult = "Player Two Wins";
      rslpsGame testGame = new rslpsGame(1,0);
      //Act
      string result = testGame.rslpsFight();
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_LizardRock_PlayerOneWins()
    {
      //Arrange
      string expectedResult = "Player Two Wins";
      rslpsGame testGame = new rslpsGame(2,0);
      //Act
      string result = testGame.rslpsFight();
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_RockScissors_PlayerTwoWins()
    {
      //Arrange
      string expectedResult = "Player One Wins";
      rslpsGame testGame = new rslpsGame(0,1);
      //Act
      string result = testGame.rslpsFight();
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_RockLizard_PlayerTwoWins()
    {
      //Arrange
      string expectedResult = "Player One Wins";
      rslpsGame testGame = new rslpsGame(0,2);
      //Act
      string result = testGame.rslpsFight();
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_SpockRock_PlayerOneWins()
    {
      //Arrange
      string expectedResult = "Player One Wins";
      rslpsGame testGame = new rslpsGame(4,0);
      //Act
      string result = testGame.rslpsFight();
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_SpockScissors_PlayerOneWins()
    {
      //Arrange
      string expectedResult = "Player One Wins";
      rslpsGame testGame = new rslpsGame(4,1);
      //Act
      string result = testGame.rslpsFight();
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_ScissorsSpock_PlayerTwoWins()
    {
      //Arrange
      string expectedResult = "Player Two Wins";
      rslpsGame testGame = new rslpsGame(1,4);
      //Act
      string result = testGame.rslpsFight();
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_RockSpock_PlayerTwoWins()
    {
      //Arrange
      string expectedResult = "Player Two Wins";
      rslpsGame testGame = new rslpsGame(1,5);
      //Act
      string result = testGame.rslpsFight();
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
