using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwinAdventure.Tests
{
    [TestClass()]
    public class IdentifiableObjectTests
    {
        [TestMethod()]
        public void TestAreYou()
        {
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });
            Assert.IsTrue(id.AreYou("fred"));
            Assert.IsTrue(id.AreYou("bob"));
        }

        [TestMethod()]
        public void TestNotAreYou()
        {
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });
            Assert.IsFalse(id.AreYou("wilma"));
            Assert.IsFalse(id.AreYou("boby"));
        }

        [TestMethod()]
        public void TestCaseSensitive()
        {
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });
            Assert.IsFalse(id.AreYou("FRED"));
            Assert.IsFalse(id.AreYou("bOB"));
        }

        [TestMethod()]
        public void TestFirstId()
        {
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });
            Assert.IsTrue(id.FirstId == "fred");
        }

        [TestMethod()]
        public void TestAddId()
        {
            IdentifiableObject id = new IdentifiableObject(new string[] { "fred", "bob" });
            id.AddIdentifier("wilma");
            Assert.IsTrue(id.AreYou("fred"));
            Assert.IsTrue(id.AreYou("bob"));
            Assert.IsTrue(id.AreYou("wilma"));
        }
    }
}