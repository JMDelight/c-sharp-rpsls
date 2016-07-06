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
      rslpsGame testGame = new rslpsGame();
      //Act
      string result = testGame.rslpsFight( 0, 0);
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_ScissorsRock_PlayerOneWins()
    {
      //Arrange
      string expectedResult = "Player One Wins";
      rslpsGame testGame = new rslpsGame();
      //Act
      string result = testGame.rslpsFight(1,0);
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_LizardRock_PlayerOneWins()
    {
      //Arrange
      string expectedResult = "Player One Wins";
      rslpsGame testGame = new rslpsGame();
      //Act
      string result = testGame.rslpsFight(2,0);
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_RockScissors_PlayerTwoWins()
    {
      //Arrange
      string expectedResult = "Player Two Wins";
      rslpsGame testGame = new rslpsGame();
      //Act
      string result = testGame.rslpsFight(0,1);
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_RockLizard_PlayerTwoWins()
    {
      //Arrange
      string expectedResult = "Player Two Wins";
      rslpsGame testGame = new rslpsGame();
      //Act
      string result = testGame.rslpsFight(0,2);
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_SpockRock_PlayerOneWins()
    {
      //Arrange
      string expectedResult = "Player One Wins";
      rslpsGame testGame = new rslpsGame();
      //Act
      string result = testGame.rslpsFight(4,0);
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_SpockScissors_PlayerOneWins()
    {
      //Arrange
      string expectedResult = "Player One Wins";
      rslpsGame testGame = new rslpsGame();
      //Act
      string result = testGame.rslpsFight(4,1);
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_ScissorsSpock_PlayerTwoWins()
    {
      //Arrange
      string expectedResult = "Player Two Wins";
      rslpsGame testGame = new rslpsGame();
      //Act
      string result = testGame.rslpsFight(1,4);
      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void rlspsFight_RockSpock_PlayerTwoWins()
    {
      //Arrange
      string expectedResult = "Player Two Wins";
      rslpsGame testGame = new rslpsGame();
      //Act
      string result = testGame.rslpsFight(1,5);
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
