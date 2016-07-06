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
      string result = testGame.rslpsFight( 1, 1);

      //Assert
      Assert.Equal(expectedResult, result);

    }
  }
}
