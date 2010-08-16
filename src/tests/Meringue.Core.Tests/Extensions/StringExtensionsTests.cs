using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Meringue.Core.Extensions;

namespace Meringue.Core.Tests.Extensions {
    
    [TestFixture]
    public class StringExtensionsTests {

        private const string SHORT_STRING = "Dogs";
        private const string LONG_STRING = "The quick brown fox jumps over the lazy dog";

        [Test]
        public void CanGetLeftNCharactersWhenStringLenGreaterThanN() {
            Assert.AreEqual(LONG_STRING.Left(3), "The");
        }

        [Test]
        public void CanGetLeftNCharactersWhenStringLenLessThanN() {
            Assert.AreEqual(SHORT_STRING.Left(10), SHORT_STRING);
        }

        [Test]
        public void CanGetLeftNCharactersWhenStringLenEqualsN() {
            Assert.AreEqual(SHORT_STRING.Left(SHORT_STRING.Length), SHORT_STRING);
        }

        [Test]
        public void CanGetRightNCharactersWhenStringLenGreaterThanN() {
            Assert.AreEqual(LONG_STRING.Right(3), "dog");
        }

        [Test]
        public void CanGetRightNCharactersWhenStringLenLessThanN() {
            Assert.AreEqual(SHORT_STRING.Right(10), SHORT_STRING);
        }

        [Test]
        public void CanGetRightNCharactersWhenStringLenEqualsN() {
            Assert.AreEqual(SHORT_STRING.Right(SHORT_STRING.Length), SHORT_STRING);
        }

    }
}
