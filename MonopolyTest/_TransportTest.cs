using NUnit.Framework;
using Monopoly;

namespace MonopolyTest
{
    class _TransportTest
    {
        [Test]
        public void TestConstructor()
        {
            Transport t = new Transport();
            Assert.AreEqual("Railway", t.ToString().Substring(0,7));
        }
    }
}
