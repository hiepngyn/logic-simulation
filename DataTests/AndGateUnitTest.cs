using Data;

namespace DataTests
{
    /// <summary>
    /// Testing class for AND gates.
    /// </summary>
    public class AndGateUnitTest
    {
        #region Default Value Test

        /// <summary>
        /// Testing default value of name.
        /// </summary>
        [Fact]
        public void AndGateNameShouldBeANDGateTest()
        {
            AndGate a = new AndGate();
            Assert.Equal("AND Gate", a.Name);
        }

        /// <summary>
        /// Testing default value of top input.
        /// </summary>
        [Fact]
        public void AndGateTopInputShouldBeFalseTest()
        {
            AndGate a = new AndGate();
            Assert.False(a.TopInput);
        }        
        
        /// <summary>
        /// Testing default value of the bottom input.
        /// </summary>
        [Fact]
        public void AndGateBottomInputShouldBeFalseTest()
        {
            AndGate a = new AndGate();
            Assert.False(a.BottomInput);
        }

        /// <summary>
        /// Testing default value of the output.
        /// </summary>
        [Fact]
        public void AndGateOutputShouldBeFalseTest()
        {
            AndGate a = new AndGate();
            Assert.False(a.OutputValue);
        }
        #endregion

        #region Use Case Test

        /// <summary>
        /// Testing by changing input values on the output
        /// </summary>
        /// <param name="topIn"> value of top input</param>
        /// <param name="bottomIn"> value of bottom input</param>
        [Theory]
        [InlineData(false,false)]
        [InlineData(true,false)]
        [InlineData(false,true)]
        public void ChangingAndGateInputsShouldStilBeFalseTest(bool topIn, bool bottomIn)
        {
            AndGate a = new AndGate();
            a.TopInput = topIn;
            a.BottomInput = bottomIn;
            Assert.False(a.OutputValue);
        }

        /// <summary>
        /// Testing by changing input values on the output
        /// </summary>
        /// <param name="topIn"> value of top input</param>
        /// <param name="bottomIn"> value of bottom input</param>
        [Theory]
        [InlineData(true, true)]
        public void ChangingAndGateInputsShouldBeTrueTest(bool topIn, bool bottomIn)
        {
            AndGate a = new AndGate();
            a.TopInput = topIn;
            a.BottomInput = bottomIn;
            Assert.True(a.OutputValue);
        }
        #endregion
    }
}