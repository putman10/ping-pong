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
      CollectionAssert.AreEqual(new int[]{0,1,2,3}, testGame.PingPongGenerator(4));
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

    [TestMethod]
    public void DivisibleByBoth_ReplacePingPong_Bool()
    {
      Pingpong testGame = new Pingpong();
      Assert.AreEqual(true, testGame.DivisibleByBoth(15));
    }

    [TestMethod]
    public void ReplaceLoop_ReplacePingPong_Void()
    {
      Pingpong testGame = new Pingpong();
      int[] array = testGame.PingPongGenerator(4);
      string[] test = new string[]{"pingpong","test","test","pong"};
      CollectionAssert.AreEqual(test, testGame.ReplaceLoop(array));
    }
  }
}
