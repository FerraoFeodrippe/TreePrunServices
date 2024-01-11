using TreePrunServices.Core.Commom.Enums;

namespace TreePrunServices.Tests.Core.Enum.Tests
{
    [TestClass]
    public class ZoneEnumTests
    {

        [TestMethod]
        public void ZoneEnum_UrbanDescription_ShouldMatch()
        {
            Assert.AreEqual("URBAN", ZoneEnum.Urban.Description);
        }

        [TestMethod]
        public void ZoneEnum_RuralDescription_ShouldMatch()
        {
            Assert.AreEqual("RURAL", ZoneEnum.Rural.Description);
        }

        [TestMethod]
        public void ZoneEnum_ToString_ShouldMatchDescription()
        {
            Assert.IsTrue(ZoneEnum.GetAll().All(e => e.Description.Equals(e.ToString())));
        }

        [TestMethod]
        public void ZoneEnum_Equals_ShouldBeEqualComparedItSelf()
        {
            Assert.IsTrue(ZoneEnum.GetAll().All(e => e.Equals(e)));
        }

        [TestMethod]
        public void ZoneEnum_Values_ShouldUnique()
        {
            Assert.IsTrue(ZoneEnum.GetAll().Count() == ZoneEnum.GetAll().Distinct().Count());
        }
    }
}
