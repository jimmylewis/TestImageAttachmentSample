using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestImageAttachmentSample
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DeploymentItem("redbox.png")]
        [TestMethod]
        public void TestMethod1()
        {
            TestContext.AddResultFile("redbox.png");
            Assert.Fail();
        }

    }
}
