using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticaLibrary;

namespace StatisticaLibrary.Test
{
    [TestClass]
    public class StatisticaTest
    {
        [TestMethod]
        public void TestIsPositivo()
        {
            int n = 2;
            bool resp = Statistica.IsPositivo(n);
            bool asp = true;
            Assert.AreEqual(asp, resp);
        }

        [DataTestMethod]
        [DataRow(2, true)]
        public void DataTestIsPositivo(int n, bool asp)
        {
            bool resp = Statistica.IsPositivo(n);
            Assert.AreEqual(asp, resp);
        }

        [TestMethod]
        public void TestContaPositivi()
        {
            int[] n = new int[] { 1, -2, 6, -3 };
            int resp = Statistica.ContaPositivi(n);
            int asp = 2;
            Assert.AreEqual(asp, resp);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, -2, 6, -3 }, 2)]
        public void DataTestContaPositivi(int[] n, int asp)
        {
            int resp = Statistica.ContaPositivi(n);
            Assert.AreEqual(asp, resp);
        }

        [TestMethod]
        public void TestPositivi()
        {
            int[] n = new int[] { 1, -2, 6, -3 };
            int[] resp = Statistica.Positivi(n);
            int[] asp = new int[] { 1, 6 };
            CollectionAssert.AreEquivalent(asp, resp);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, -2, 6, -3 }, new int[] { 1, 6 })]
        public void DataTestPositivi(int[] n, int[] asp)
        {
            int[] resp = Statistica.Positivi(n);
            CollectionAssert.AreEquivalent(asp, resp);
        }
    }
}
