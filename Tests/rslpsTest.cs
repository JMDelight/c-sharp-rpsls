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
  }
}
