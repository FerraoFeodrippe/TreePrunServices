using TreePrunServices.Cross.Definitions.Enums;

namespace TreePrunServices.Tests.Cross.Enums
{
    [TestClass]
    public class BaseEnumTests
    {
        private readonly static Type[] _assembliesWithEnum = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(a => a.GetTypes().Where(t => t.BaseType?.Name.Equals(typeof(BaseEnum<>).Name) ?? false))
                .ToArray();

        [TestMethod]
        public void BaseEnum_ChildrenShouldHaveOnlyPrivateContructors()
        {
            var onlyPrivateContructors = _assembliesWithEnum
                .All(t => t.GetConstructors().All(c => c.IsPrivate));

            Assert.IsTrue(onlyPrivateContructors);
        }

        [TestMethod]
        public void BaseEnum_ChildrenShouldBeSealed()
        {
            var allChildrenSealed = _assembliesWithEnum
                .All(t => t.IsSealed);

            Assert.IsTrue(allChildrenSealed);
        }
    }
}
