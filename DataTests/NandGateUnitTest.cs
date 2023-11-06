using Data;

namespace DataTests
{
    /// <summary>
    /// Testing class for NAND gates.
    /// </summary>
    public class NandGateUnitTest
    {
        #region Default Value Test

        /// <summary>
        /// Testing default value of name.
        /// </summary>
        [Fact]
        public void NandGateNameShouldBeNANDGateTest()
        {
            NandGate n = new NandGate();
            Assert.Equal("NAND Gate", n.Name);
        }

        /// <summary>
        /// Testing default value of top input.
        /// </summary>
        [Fact]
        public void NandGateTopInputShouldBeFalseTest()
        {
            NandGate n = new NandGate();
            Assert.False(n.TopInput);
        }

        /// <summary>
        /// Testing default value of the bottom input.
        /// </summary>
        [Fact]
        public void NandGateBottomInputShouldBeFalseTest()
        {
            NandGate n = new NandGate();
            Assert.False(n.BottomInput);
        }

        /// <summary>
        /// Testing default value of the output.
        /// </summary>
        [Fact]
        public void NandGateOutputShouldBeTrueTest() // Inverse of AND Gate
        {
            NandGate n = new NandGate();
            Assert.True(n.OutputValue);
        }
        #endregion

        #region Use Case Test

        /// <summary>
        /// Testing by changing input values on the output.
        /// </summary>
        /// <param name="topIn">Value of top input.</param>
        /// <param name="bottomIn">Value of bottom input.</param>
        [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void ChangingNandGateInputsShouldBeTrueTest(bool topIn, bool bottomIn)
        {
            NandGate n = new NandGate();
            n.TopInput = topIn;
            n.BottomInput = bottomIn;
            Assert.True(n.OutputValue); // Inverse of AND Gate
        }

        /// <summary>
        /// Testing by changing input values on the output.
        /// </summary>
        /// <param name="topIn">Value of top input.</param>
        /// <param name="bottomIn">Value of bottom input.</param>
        [Theory]
        [InlineData(true, true)]
        public void ChangingNandGateInputsShouldBeFalseTest(bool topIn, bool bottomIn)
        {
            NandGate n = new NandGate();
            n.TopInput = topIn;
            n.BottomInput = bottomIn;
            Assert.False(n.OutputValue); // Inverse of AND Gate
        }
        #endregion
    }
}
