using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lab17.Library.Tests
{
    [TestFixture]
    public class PrimesIndexMatcherTests
    {
        [Test]
        public void Index_Matcher_When1_Returns2()
        {
            // Assemble
            int index = 1;
            // Act
            int output = PrimeIndexMatcher.GetValue(index);
            // Assert
            Assert.AreEqual(2, output);
        }

        [Test]
        public void Index_Matcher_When2_Returns3()
        {
            // Assemble
            int input = 2;
            // Act
            int output = PrimeIndexMatcher.GetValue(input);
            // Assert
            Assert.AreEqual(3, output);
        }
    }
}
