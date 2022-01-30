using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestGithubActions;

namespace TestGithubActionsTests
{
    [TestClass]
    public class SimpleMathTest
    {
        [TestMethod]
        public void ShouldAddCorrectly()
        {
            // Setup
            decimal a = 15;
            decimal b = 7;

            // Execute
            decimal result = SimpleMath.Add(a, b);

            // Evaluate
            decimal excpacted = 22;
            Assert.AreEqual(excpacted, result);
        }

        [TestMethod]
        public void ShouldSubtract()
        {
            // Setup
            decimal a = 4;
            decimal b = 5;

            // Execute
            decimal result = SimpleMath.Subtract(a, b);

            // Evaluate
            decimal expacted = -1;
            Assert.AreEqual(expacted, result);
        }

        [TestMethod]
        public void ShouldDivide()
        {
            // Setup
            decimal a = 20;
            decimal b = 10;

            // Execute
            decimal result = SimpleMath.Divide(a, b);

            // Evaluate
            // Will fail, for test reasons
            decimal expacted = 2;
            Assert.AreEqual(expacted, result);
        }
    }
}
