using NUnit.Framework;

namespace FuzzBuzz.Tests
{
    public class Tests
    {
        /// <summary>
        /// Given an integer input
        /// <para />
        /// When the mod of the division by three is equal zero
        /// Than fill up the output varible with the string "Fuzz"
        /// </summary>
        [Test]
        public void FuzzBuzz_WhenModOfThreeEqualsZero_ReturnsStringFuzz()
        {
            //Arrange
            int input = 3;
            string output = string.Empty;
            
            //Act
            if(input %3 == 0){
                output += "Fuzz";
            }

            //Assert
            Assert.AreEqual("Fuzz", output);
        }
    }
}