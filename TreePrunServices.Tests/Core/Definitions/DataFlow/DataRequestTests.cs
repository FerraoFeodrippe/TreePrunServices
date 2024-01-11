
using TreePrunServices.Core.Commom.Definitions.DataFlow;

namespace TreePrunServices.Tests.Core.Definitions.DataFlow
{
    [TestClass]
    public class DataRequestTests
    {
        [TestMethod]
        public void DataRequest_InputedData_ShouldBeSameData()
        {
            int data = 99;

            var request = DataRequest<int>.Create(data);

            Assert.AreEqual(data, request.Data);
        }
    }
}
