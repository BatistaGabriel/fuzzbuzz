using System;

namespace FuzzBuzz.Library
{
    public static class FuzzerBuzzer
    {
        /// <summary>
        /// This method will return return a string based on the following rule:
        /// <para />
        /// if the <b>mod of the division by three is zero</b> returns: <code>"Fuzz"</code>
        /// <para />
        /// if the <b>mod of the division by five is zero</b> returns: <code>"Buzz"</code>
        /// <para />
        /// if the <b>mod of the division by three and five is not zero</b> 
        /// returns: <code>the inputed value as string</code>
        /// </summary>
        /// <param name="input">The value that will be checked</param>
        /// <returns></returns>
        public static string GetValue(int input){
            string output = string.Empty;

            if(IsModOfThreeEqualsZero(input)){
                output += "Fuzz";
            }

            if(IsModOfFiveEqualsZero(input)){
                output += "Buzz";
            }

            if(string.IsNullOrEmpty(output)){
                output = input.ToString();
            }

            return output;
        }

        /// <summary>
        /// Checks if the mod of the division of the informed value
        /// by three is zero.
        /// </summary>
        /// <param name="input">The value that will be checked</param>
        /// <returns></returns>
        private static bool IsModOfThreeEqualsZero(int input){
            return input %3 == 0;
        }

        /// <summary>
        /// Checks if the mod of the division of the informed value
        /// by five is zero.
        /// </summary>
        /// <param name="input">The value that will be checked</param>
        /// <returns></returns>
        private static bool IsModOfFiveEqualsZero(int input){
            return input %5 == 0;
        }
    }
}
