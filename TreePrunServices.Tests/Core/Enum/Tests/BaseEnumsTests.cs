using System.Reflection;
using TreePrunServices.Core.Commom.Enum;

namespace TreePrunServices.Tests.Core.Enum.Tests
{
    [TestClass]
    public class BaseEnumsTests
    {
        [TestMethod]
        public void BaseEnum_ChildrenShouldHaveOnlyPrivateContructors()
        {
            var onlyPrivateContructors = Assembly
                .GetAssembly(typeof(BaseEnum<>))?
                .GetTypes()
                .Where(t => t.BaseType?.Name.Equals(typeof(BaseEnum<>).Name) ?? false)
                .All(t=> t.GetConstructors().All(c=> c.IsPrivate));

            Assert.IsTrue(onlyPrivateContructors);
        }

        [TestMethod]
        public void BaseEnum_ChildrenShouldBeSealed()
        {
            var allChildrenSealed = Assembly
                .GetAssembly(typeof(BaseEnum<>))?
                .GetTypes()
                .Where(t => t.BaseType?.Name.Equals(typeof(BaseEnum<>).Name) ?? false)
                .All(t => t.IsSealed);

            Assert.IsTrue(allChildrenSealed);
        }
    }
}
