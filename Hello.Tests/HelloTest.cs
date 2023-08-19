using HelloWorldAutoGraded;

namespace Hello.Tests;

[TestClass]
public class HelloTest
{
    [TestMethod]
    public void TestIfSayHelloReturnsCorrectValue()
    {
        Assert.AreEqual("Hello, World!", SayHelloClass.SayHello(), "Incorrect message displayed.");
    }

    [TestMethod]
    public void TestSayHelloReturnTypeIsString()
    {
        Assert.AreEqual("System.String", SayHelloClass.SayHello().GetType().ToString());
    }
}
