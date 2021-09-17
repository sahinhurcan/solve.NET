using System;
using System.Collections.Generic;
using System.Text;
using Solve.NET.UnitConversion;
using NUnit.Framework;

namespace Solve.NET.Tests.UnitConversion
{
    [TestFixture()]
    public class SpeedConverterTest
    {
        [SetUp()]
        public void Setup()
        {
            //TODO: NUnit setup
        }

        [TearDown()]
        public void TearDown()
        {
            //TODO: NUnit TearDown
        }

        [Test()]
        public void Example()
        {
            double result = SpeedConverter.Convert(
                SpeedUnit.MeterPerSecond, SpeedUnit.KilometerPerHour, 60);
            Assert.AreEqual(216d, result);

            result = SpeedConverter.Convert(
                SpeedUnit.MilePerHour, SpeedUnit.KilometerPerHour, 60);
            Assert.AreEqual(96.560639999999992d, result);
        }
    }
}
