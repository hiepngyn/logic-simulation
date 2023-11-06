using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace DataTests
{
    /// <summary>
    /// Testing class for XNOR gates.
    /// </summary>
    public class XnorGateUnitTest
    {
        #region Default Value Test

        /// <summary>
        /// Testing default value of name.
        /// </summary>
        [Fact]
        public void XnorGateNameShouldBeXNORGateTest()
        {
            XnorGate xn = new XnorGate();
            Assert.Equal("XNOR Gate", xn.Name);
        }

        /// <summary>
        /// Testing default value of top input.
        /// </summary>
        [Fact]
        public void XnorGateTopInputShouldBeFalseTest()
        {
            XnorGate xn = new XnorGate();
            Assert.False(xn.TopInput);
        }

        /// <summary>
        /// Testing default value of the bottom input.
        /// </summary>
        [Fact]
        public void XnorGateBottomInputShouldBeFalseTest()
        {
            XnorGate xn = new XnorGate();
            Assert.False(xn.BottomInput);
        }

        /// <summary>
        /// Testing default value of the output.
        /// </summary>
        [Fact]
        public void XnorGateOutputShouldBeTrueTest()
        {
            XnorGate xn = new XnorGate();
            Assert.True(xn.OutputValue);
        }
        #endregion

        #region Use Case Test

        /// <summary>
        /// Testing that XNOR gate output is false when inputs differ.
        /// </summary>
        /// <param name="topIn">Value of top input.</param>
        /// <param name="bottomIn">Value of bottom input.</param>
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void ChangingXnorGateInputsShouldBeFalseTest(bool topIn, bool bottomIn)
        {
            XnorGate xn = new XnorGate();
            xn.TopInput = topIn;
            xn.BottomInput = bottomIn;
            Assert.False(xn.OutputValue);
        }

        /// <summary>
        /// Testing that XNOR gate output is true when inputs are the same.
        /// </summary>
        /// <param name="topIn">Value of top input.</param>
        /// <param name="bottomIn">Value of bottom input.</param>
        [Theory]
        [InlineData(false, false)]
        [InlineData(true, true)]
        public void ChangingXnorGateInputsShouldBeTrueTest(bool topIn, bool bottomIn)
        {
            XnorGate xn = new XnorGate();
            xn.TopInput = topIn;
            xn.BottomInput = bottomIn;
            Assert.True(xn.OutputValue);
        }
        #endregion
    }
}
