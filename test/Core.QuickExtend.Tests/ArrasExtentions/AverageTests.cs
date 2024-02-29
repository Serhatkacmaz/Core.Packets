﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.QuickExtend.Tests.ArrasExtentions
{
    internal class AverageTests
    {
        [Test]
        public void Average_ComputesAverageOfElementsInArray()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };

            // Act
            double result = array.Average();

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Average_EmptyArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = new int[0];

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => array.Average());
        }
    }
}
