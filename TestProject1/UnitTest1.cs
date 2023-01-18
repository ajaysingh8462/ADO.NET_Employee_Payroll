using Employee_Payroll;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UpdateDetails up = new UpdateDetails();
            string name = "Terisa";
            double basic_Pay = 30000;
            string actual = up.UpdateBasicPay(name,basic_Pay);
            string expected = "Updated!";
            Assert.AreEqual(expected, actual);

        }
    }
}