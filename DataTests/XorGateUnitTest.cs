using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;
namespace DataTests
{
    /// <summary>
    /// Testing class for XOR gates.
    /// </summary>
    public class XorGateUnitTest
    {
        #region Default Value Test

        /// <summary>
        /// Testing default value of name.
        /// </summary>
        [Fact]
        public void XorGateNameShouldBeXORGateTest()
        {
            XorGate x = new XorGate();
            Assert.Equal("XOR Gate", x.Name);
        }

        /// <summary>
        /// Testing default value of top input.
        /// </summary>
        [Fact]
        public void XorGateTopInputShouldBeFalseTest()
        {
            XorGate x = new XorGate();
            Assert.False(x.TopInput);
        }

        /// <summary>
        /// Testing default value of the bottom input.
        /// </summary>
        [Fact]
        public void XorGateBottomInputShouldBeFalseTest()
        {
            XorGate x = new XorGate();
            Assert.False(x.BottomInput);
        }

        /// <summary>
        /// Testing default value of the output.
        /// </summary>
        [Fact]
        public void XorGateOutputShouldBeFalseTest()
        {
            XorGate x = new XorGate();
            Assert.False(x.OutputValue);
        }
        #endregion

        #region Use Case Test

        /// <summary>
        /// Testing that XOR gate output is true only when inputs differ.
        /// </summary>
        /// <param name="topIn">Value of top input.</param>
        /// <param name="bottomIn">Value of bottom input.</param>
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void ChangingXorGateInputsShouldBeTrueTest(bool topIn, bool bottomIn)
        {
            XorGate x = new XorGate();
            x.TopInput = topIn;
            x.BottomInput = bottomIn;
            Assert.True(x.OutputValue);
        }

        /// <summary>
        /// Testing that XOR gate output is false when inputs are the same.
        /// </summary>
        /// <param name="topIn">Value of top input.</param>
        /// <param name="bottomIn">Value of bottom input.</param>
        [Theory]
        [InlineData(false, false)]
        [InlineData(true, true)]
        public void ChangingXorGateInputsShouldBeFalseTest(bool topIn, bool bottomIn)
        {
            XorGate x = new XorGate();
            x.TopInput = topIn;
            x.BottomInput = bottomIn;
            Assert.False(x.OutputValue);
        }
        #endregion
    }
}