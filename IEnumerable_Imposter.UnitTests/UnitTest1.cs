using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable_Imposter.UnitTests
{
    [TestClass]
    public class IEnumerableImposterTests
    {
        [TestMethod]
        public void GetEnumerator_IteratesInfinitely()
        {
            // Arrange
            IEnumerableImposter ienumerableImposter = new IEnumerableImposter();
            OutOfMemoryException outOfMemoryException = null;

            // Act
            try
            {
                new List<int>(ienumerableImposter);
            }
            catch (OutOfMemoryException ex)
            {
                outOfMemoryException = ex;
            }

            // Assert
            Assert.IsNotNull(outOfMemoryException);
        }
    }
}
