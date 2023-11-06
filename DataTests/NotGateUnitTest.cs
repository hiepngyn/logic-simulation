using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;

namespace DataTests
{
    /// <summary>
    /// Testing class for NOT gates.
    /// </summary>
    public class NotGateUnitTest
    {
        #region Default Value Test

        /// <summary>
        /// Testing default value of name.
        /// </summary>
        [Fact]
        public void NotGateNameShouldBeNOTGateTest()
        {
            NotGate n = new NotGate();
            Assert.Equal("NOT Gate", n.Name);
        }

        /// <summary>
        /// Testing default value of input.
        /// </summary>
        [Fact]
        public void NotGateInputShouldBeFalseTest()
        {
            NotGate n = new NotGate();
            Assert.False(n.InputValue);
        }

        /// <summary>
        /// Testing default value of the output.
        /// </summary>
        [Fact]
        public void NotGateOutputShouldBeTrueTest()
        {
            NotGate n = new NotGate();
            Assert.True(n.OutputValue);
        }
        #endregion

        #region Use Case Test

        /// <summary>
        /// Testing NOT gate output is the inverse of the input.
        /// </summary>
        /// <param name="input">Value of input.</param>
        /// <param name="expectedOutput">Expected value of output.</param>
        [Theory]
        [InlineData(false, true)]
        [InlineData(true, false)]
        public void ChangingNotGateInputShouldInvertOutputTest(bool input, bool expectedOutput)
        {
            NotGate n = new NotGate();
            n.InputValue = input;
            Assert.Equal(expectedOutput, n.OutputValue);
        }
        #endregion
    }
}
