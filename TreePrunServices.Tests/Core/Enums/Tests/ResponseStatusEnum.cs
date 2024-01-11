using TreePrunServices.Core.Commom.Enums;

namespace TreePrunServices.Tests.Core.Enum.Tests
{
    [TestClass]
    public class ResponseStatusEnumTests
    {

        [TestMethod]
        public void ResponseStatusEnum_OkDescription_ShouldMatch()
        {
            Assert.AreEqual("OK", ResponseStatusEnum.Ok.Description);
        }

        [TestMethod]
        public void ResponseStatusEnum_ErrorDescription_ShouldMatch()
        {
            Assert.AreEqual("ERROR", ResponseStatusEnum.Error.Description);
        }

        [TestMethod]
        public void ResponseStatusEnum_ToString_ShouldMatchDescription()
        {
            Assert.IsTrue(ResponseStatusEnum.GetAll().All(e => e.Description.Equals(e.ToString())));
        }

        [TestMethod]
        public void ResponseStatusEnum_Equals_ShouldBeEqualComparedItSelf()
        {
            Assert.IsTrue(ResponseStatusEnum.GetAll().All(e => e.Equals(e)));
        }

        [TestMethod]
        public void ResponseStatusEnum_Values_ShouldUnique()
        {
            Assert.IsTrue(ResponseStatusEnum.GetAll().Count() == ResponseStatusEnum.GetAll().Distinct().Count());
        }
    }
}
