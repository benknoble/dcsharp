// Test.cs
// 
using NUnit.Framework;
using DCSharp.Core;
namespace Test
{
    [TestFixture]
    public class EngineTest
    {
        [Test]
        public void ConstructEngine ()
        {
            var e = new Engine ();
        }

        [Test]
        public void Push ()
        {
            var e = new Engine ();
            e.Push (new DataElement (0));
            e.Push (new DataElement (decimal.MaxValue));
            e.Push (new DataElement (decimal.MinValue));
            e.Push (new DataElement (decimal.MinusOne));
        }
    }
}
