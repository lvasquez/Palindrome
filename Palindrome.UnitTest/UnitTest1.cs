using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPalindromeReturnNotNull()
        {

            Palindrome ob = new Palindrome();

            var r = ob.IsPalindrome("Hola");

            Assert.IsNotNull(r);
        }


        [TestMethod]
        public void IsPalindromeReturnTypeOf()
        {

            Palindrome ob = new Palindrome();

            var r = ob.IsPalindrome("Hola");

            Assert.IsInstanceOfType(r, typeof(bool));
        }


        [TestMethod]
        public void IsPalindromeReturnTrue()
        {

            Palindrome ob = new Palindrome();

            var r = ob.IsPalindrome("Deleveled");

            Assert.IsTrue(r);
        }


        [TestMethod]
        public void IsPalindromeReturnFalse()
        {

            Palindrome ob = new Palindrome();

            var r = ob.IsPalindrome("Hola");

            Assert.IsFalse(r);
        }
    }
}
