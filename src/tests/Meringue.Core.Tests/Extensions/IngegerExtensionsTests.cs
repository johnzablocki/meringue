using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Meringue.Core.Extensions;

namespace Meringue.Core.Tests.Extensions {
    
    [TestFixture]    
    public class IngegerExtensionsTests {

        [Test]
        public void CanCreateArrayOfNIntsFromStartToEndWithTo() {

            int[] ints = 1.To(10);
            Assert.AreEqual(ints.Length, 10);
            Assert.AreEqual(ints[0], 1);
            Assert.AreEqual(ints[9], 10);        
        }

        [Test]
        public void CanCreateArrayOfNIntsFromEndToStartWithTo() {

            int[] ints = 10.To(1);           
            Assert.AreEqual(ints.Length, 10);
            Assert.AreEqual(ints[0], 10);
            Assert.AreEqual(ints[9], 1);          
            
        }

        [Test]
        public void CanCreateArrayOfNIntsWhenStartEqualsEndWithTo() {

            int[] ints = 10.To(10);
            Assert.AreEqual(ints.Length, 1);
            Assert.AreEqual(ints[0], 10);            
        }

    }
}
