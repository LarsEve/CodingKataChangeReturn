using CodingKataChangeReturn;
using NUnit.Framework;

namespace NUnitCodingKataChangeReturn
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestValid()
        {
            Assert.AreEqual(2, 2);
        }
        [Test]
        public void TestInvalid()
        {
            Assert.AreEqual(2, 3);
        }
        [Test]
        public void CheckCalculate40()
        {
            Assert.IsTrue(40 == Calculater.calcAndWriteReturn("{0}-Euro-Scheine:{1}", 40, 10));
        }
    }
}