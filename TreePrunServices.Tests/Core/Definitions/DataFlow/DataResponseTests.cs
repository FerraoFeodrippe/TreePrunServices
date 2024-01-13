

using TreePrunServices.Cross.Definitions.DataFlow;

namespace TreePrunServices.Tests.Core.Definitions.DataFlow
{
    [TestClass]
    public class DataResponseTests
    {
        [TestMethod]
        public void DataResponse_NoErrorMessage_ShouldReturnStatusOk()
        {
            var dataResponse1 = DataResponse<int>.Create(1);

            Assert.IsTrue(dataResponse1.StatusEnum.IsOk);
        }

        [TestMethod]
        public void DataResponse_ExistsErrorMessage_ShouldReturnStatusNonOk()
        {
            var dataResponseE = DataResponse<int>.Create();

            dataResponseE.AddError("error x", "message y");

            Assert.IsFalse(dataResponseE.StatusEnum.IsOk);
        }
    }
}
