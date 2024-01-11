
using TreePrunServices.Core.Commom.Definitions.DataFlow;

namespace TreePrunServices.Tests.Core.Definitions.DataFlow
{
    [TestClass]
    public class DataRequestTests
    {
        [TestMethod]
        public void DataRequest_InputedDataField_ShouldBeSameData()
        {
            DataRequestValue data = DataRequestValue.Create("field1", 1);

            var request = DataRequest.Create(data);

            Assert.AreEqual(data.GetValue("field1"), request.Value.GetValue("field1"));
        }
    }
}
