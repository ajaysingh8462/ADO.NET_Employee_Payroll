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
            string actual = up.UpdateBasicPay(name);
            string expected = "Updated!";
            Assert.AreEqual(expected, actual);

        }
    }
}