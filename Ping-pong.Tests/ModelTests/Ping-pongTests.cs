using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace Games.Tests
{
  [TestClass]
  public class GameTest
  {
    [TestMethod]
    public void PingPongGenerator_CreateRange_True()
    {
      Pingpong testGame = new Pingpong();
      CollectionAssert.AreEqual(new int[]{0,1}, testGame.PingPongGenerator(2));
    }

    [TestMethod]
    public void DivisibleByThree_ReplacePing_Bool()
    {
      Pingpong testGame = new Pingpong();
      Assert.AreEqual(true, testGame.DivisibleByThree(3));
    }

    [TestMethod]
    public void DivisibleByFive_ReplacePong_Bool()
    {
      Pingpong testGame = new Pingpong();
      Assert.AreEqual(true, testGame.DivisibleByFive(5));
    }
  }
}
