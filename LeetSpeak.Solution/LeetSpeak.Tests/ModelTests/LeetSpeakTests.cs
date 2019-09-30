using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class TranslatorTest
  {
    [TestMethod]
    public void EnglishToLeet_ETo3_Fr33()
    {
      Translator leet = new Translator();
      Assert.AreEqual("Fr33", leet.EnglishToLeet("Free"));
    }
    [TestMethod]
    public void EnglishToLeet_ATo4_Sp34k()
    {
      Translator leet = new Translator();
      Assert.AreEqual("Sp34k", leet.EnglishToLeet("Speak"));
    }
    [TestMethod]
    public void EnglishToLeet_OTo0_B00k()
    {
      Translator leet = new Translator();
      Assert.AreEqual("B00k", leet.EnglishToLeet("Book"));
    }
    [TestMethod]
    public void EnglishToLeet_LTo1_100k()
    {
      Translator leet = new Translator();
      Assert.AreEqual("100k", leet.EnglishToLeet("Look"));
    }
    [TestMethod]
    public void EnglishToLeet_SToZ_()
    {
      Translator leet = new Translator();
      Assert.AreEqual("3lz3", leet.EnglishToLeet("else"));
    }
    [TestMethod]
    public void EnglishToLeet_TTo7_()
    {
      Translator leet = new Translator();
      Assert.AreEqual("1337", leet.EnglishToLeet("Leet"));
    }

    [TestMethod]
    public void EnglishToLeet_CKToX_()
    {
      Translator leet = new Translator();
      Assert.AreEqual("Sl4x0r", leet.EnglishToLeet("Slacker"));
    }

    [TestMethod]
    public void EnglishToLeet_ArcTest_()
    {
      Translator leet = new Translator();
      Assert.AreEqual("4rc", leet.EnglishToLeet("Arc"));
    }

  }
}