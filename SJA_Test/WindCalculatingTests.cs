using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkiJumpAggregator;
using SkiJumpAggregator.View;
using SkiJumpAggregator.Model;
using SkiJumpAggregator.ViewModel;

namespace SJA_Test
{
    [TestClass]
    public class WindCalculatingTests
    {
        [TestMethod]
        public void IsWindCountingCorrectTest()
        {
            WindCalculatorModel windCalculatorModel = new WindCalculatorModel();
            double testScore = windCalculatorModel.CalculateToPoints(200, 250, 1.0d);
            Assert.IsNotNull(testScore);
        }

        [TestMethod]
        [ExpectedException(typeof(HillTooSmallException), "Wyrzucono wyjątek")]
        public void IsHillTooSmallExceptionThrowing()
        {
            WindCalculatorModel windCalculatorModel = new WindCalculatorModel();
            windCalculatorModel.CalculateToPoints(19, 30, 1.0d);

        }


    }
}
