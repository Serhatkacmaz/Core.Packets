﻿using Core.QuickExtend.EnumExtensions.Gets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.QuickExtend.Tests.EnumExtensions.Gets;

internal class GetValueTests
{
    public enum SampleEnum
    {
        Value1 = 10,
        Value2 = 20,
        Value3 = 30
    }

    [Test]
    public void GetValue_ShouldReturnIntegerValueOfEnumItem()
    {
        // Arrange
        SampleEnum enumValue = SampleEnum.Value2;

        // Act
        int value = enumValue.GetValue();

        // Assert
        Assert.That(value, Is.EqualTo(20));
    }
}