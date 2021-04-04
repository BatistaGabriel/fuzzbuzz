using NUnit.Framework;
using FuzzBuzz.Library;

namespace FuzzBuzz.Tests
{
    public class Tests
    {
        /// <summary>
        /// Given an integer input
        /// <para />
        /// When the mod of the division by three is equal zero
        /// <para />
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

        /// <summary>
        /// Given an integer input
        /// <para />
        /// When the mod of the division by five is equal zero
        /// <para />
        /// Than fill up the output varible with the string "Buzz"
        /// </summary>
        [Test]
        public void FuzzBuzz_WhenModOfFiveEqualsZero_ReturnsStringBuzz(){
            //Arrange
            int input = 5;
            string output = FuzzerBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("Buzz", output);
        }

        /// <summary>
        /// Given an integer input
        /// <para />
        /// When the mod of the division by three is equal zero
        /// <para />
        /// And also the mod of the division by five is equal zero
        /// <para />
        /// Than fill up the output varible with the string "FuzzBuzz"
        /// </summary>
        [Test]
        public void FuzzBuzz_WhenModOfThreeAndModOfFiveEqualsZero_ReturnsStringFuzzBuzz(){
            //Arrange
            int input = 15;
            string output = FuzzerBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("FuzzBuzz", output);
        }

        /// <summary>
        /// Given an integer input
        /// <para />
        /// When the mod of the division by three is not equal zero
        /// <para />
        /// And also the mod of the division by five is not equal zero
        /// <para />
        /// Than fill up the output varible with the inputed value as a string
        /// </summary>
        [Test]
        public void FuzzBuzz_WhenModOfThreeAndModOfFiveNotEqualsZero_ReturnsInputAsString(){
            //Arrange
            int input = 1;
            string output = FuzzerBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual(input.ToString(), output);
        }
    }
}