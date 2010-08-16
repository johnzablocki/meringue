using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Meringue.Core.Extensions;

namespace Meringue.Core.Tests.Extensions {
    
    [TestFixture]
    public class IEnumerableExtensionsTests {

        [Test]
        public void CanSumIntListUsingForEach() {

            int[] ints = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            ints.ForEach(i => sum += i);
            Assert.AreEqual(sum, 15);
            
        }

        [Test]
        public void CanSumIntListUsingTryForEach() {

            object[] ints = new object[] { 1, 2, "3", 4, 5 };
            int sum = 0;
            int errorCount = 0;
            ints.TryForEach(i => sum += (int)i, (e) => errorCount++);
            Assert.AreEqual(sum, 12);
            Assert.AreEqual(errorCount, 1);
        }

    }
}
