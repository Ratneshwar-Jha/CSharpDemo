using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Setup method");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("Method 1");
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("Method 2");
        }

        [TearDown]
        public void Teardown()
        {
            TestContext.Progress.WriteLine("Tear Down");
        }
    }
}