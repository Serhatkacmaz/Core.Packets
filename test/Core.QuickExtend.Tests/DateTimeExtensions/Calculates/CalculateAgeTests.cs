﻿using Core.QuickExtend.DateTimeExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.QuickExtend.Tests.DateTimeExtensions.Calculates;

internal class CalculateAgeTests
{
    [Test]
    public void CalculateAge_ShouldReturnCorrectAge()
    {
        // Arrange
        DateTime birthDate = new DateTime(1990, 1, 1);

        // Act
        var age = birthDate.CalculateAge();

        // Assert
        Assert.That(age, Is.EqualTo(34)); // 2024 - 1990 = 34
    }
}
