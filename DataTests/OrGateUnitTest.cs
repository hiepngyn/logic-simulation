using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTests
{
    /// <summary>
    /// Testing class for OR gates.
    /// </summary>
    public class OrGateUnitTest
    {
        #region Default Value Test

        /// <summary>
        /// Testing the default name of the gate.
        /// </summary>
        [Fact]
        public void OrGateNameShouldBeORGateTest()
        {
            OrGate o = new OrGate();
            Assert.Equal("OR Gate", o.Name);
        }

        /// <summary>
        /// Testing the default value of the top input.
        /// </summary>
        [Fact]
        public void OrGateTopInputShouldBeFalseTest()
        {
            OrGate o = new OrGate();
            Assert.False(o.TopInput);
        }

        /// <summary>
        /// Testing the default value of the bottom input.
        /// </summary>
        [Fact]
        public void OrGateBottomInputShouldBeFalseTest()
        {
            OrGate o = new OrGate();
            Assert.False(o.BottomInput);
        }

        /// <summary>
        /// Testing the default value of the output.
        /// </summary>
        [Fact]
        public void OrGateOutputShouldBeFalseTest()
        {
            OrGate o = new OrGate();
            Assert.False(o.OutputValue);
        }
        #endregion

        #region Use Case Test

        /// <summary>
        /// Testing by changing input values on the output
        /// </summary>
        /// <param name="topIn"> value of top input</param>
        /// <param name="bottomIn"> value of bottom input</param>
        [Theory]
        [InlineData(false, false)]
        public void ChangingAndGateInputsShouldStilBeFalseTest(bool topIn, bool bottomIn)
        {
            OrGate o = new OrGate();
            o.TopInput = topIn;
            o.BottomInput = bottomIn;
            Assert.False(o.OutputValue);
        }

        /// <summary>
        /// Testing by changing input values on the output
        /// </summary>
        /// <param name="topIn"> value of top input</param>
        /// <param name="bottomIn"> value of bottom input</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void ChangingAndGateInputsShouldBeTrueTest(bool topIn, bool bottomIn)
        {
            OrGate o = new OrGate();
            o.TopInput = topIn;
            o.BottomInput = bottomIn;
            Assert.True(o.OutputValue);
        }
        #endregion
    }
}
