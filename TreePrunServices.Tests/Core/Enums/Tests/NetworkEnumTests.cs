using TreePrunServices.Core.Commom.Enums;

namespace TreePrunServices.Tests.Core.Enum.Tests
{
    [TestClass]
    public class NetworkEnumTests
    {

        [TestMethod]
        public void NetworkEnum_AtDescription_ShouldMatch()
        {
            Assert.AreEqual("AT", NetworkEnum.At.Description);
        }

        [TestMethod]
        public void NetworkEnum_BtDescription_ShouldMatch()
        {
            Assert.AreEqual("BT", NetworkEnum.Bt.Description);
        }

        [TestMethod]
        public void NetworkEnum_MtDescription_ShouldMatch()
        {
            Assert.AreEqual("MT", NetworkEnum.Mt.Description);
        }

        [TestMethod]
        public void NetworkEnum_ToString_ShouldMatchDescription()
        {
            Assert.IsTrue(NetworkEnum.GetAll().All(e => e.Description.Equals(e.ToString())));
        }

        [TestMethod]
        public void NetworkEnum_Equals_ShouldBeEqualComparedItSelf()
        {
            Assert.IsTrue(NetworkEnum.GetAll().All(e => e.Equals(e)));
        }

        [TestMethod]
        public void NetworkEnum_Values_ShouldUnique()
        {
            Assert.IsTrue(NetworkEnum.GetAll().Count() == NetworkEnum.GetAll().Distinct().Count());
        }
    }
}
