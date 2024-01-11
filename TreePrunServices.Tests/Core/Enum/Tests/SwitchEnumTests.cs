using TreePrunServices.Core.Commom.Enum;

namespace TreePrunServices.Tests.Core.Enum.Tests
{
    [TestClass]
    public class SwitchEnumTests
    {

        [TestMethod]
        public void SwitchEnum_SelectorDescription_ShouldMatch()
        {
            Assert.AreEqual("SELECTOR", SwitchEnum.Selector.Description);
        }

        [TestMethod]
        public void SwitchEnum_RegulatorDescription_ShouldMatch()
        {
            Assert.AreEqual("REGULATOR", SwitchEnum.Regulator.Description);
        }

        [TestMethod]
        public void SwitchEnum_ToString_ShouldMatchDescription()
        {
            Assert.IsTrue(SwitchEnum.GetAll().All(e => e.Description.Equals(e.ToString())));
        }

        [TestMethod]
        public void SwitchEnum_Equals_ShouldBeEqualComparedItSelf()
        {
            Assert.IsTrue(SwitchEnum.GetAll().All(e => e.Equals(e)));
        }

        [TestMethod]
        public void SwitchEnum_Values_ShouldUnique()
        {
            Assert.IsTrue(SwitchEnum.GetAll().Count() == SwitchEnum.GetAll().Distinct().Count());
        }
    }
}
