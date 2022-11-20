using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace HaloAssignmentDemo
{
    public class ManageConversions
    {
        /// <summary>
        /// This method receives a string of alphanumeric characters and returns the whole numbers that is in that string.
        /// </summary>
        /// <param name="inputString">The strng of alphanumeric characters</param>
        /// <returns>The list of whole numbers found in the string</returns>
        /// <exception cref="Exception"></exception>
        public static ImmutableList<long> GetWholeNumbers(string inputString)
        {
            List<long> wholeNumbers = new();            

            Regex RegexToLocateNumber = new(@"(?<number>-?(\d+(\.\d+)?)|(\.\d+))");

            try
            {
                var matchesFound = RegexToLocateNumber.Matches(inputString).ToList();                

                foreach (var match in matchesFound)
                {
                    long wholeNumber;                    

                    if (match.ToString().Contains('.'))
                    {
                        //If the number located is a decimal number, round it up to the nearest whole number
                        var decimalNumber = Convert.ToDouble(match.Value);
                        wholeNumber = (long)Math.Round(decimalNumber, 0);
                    }
                    else
                    {                        
                        wholeNumber = Convert.ToInt64(match.Value);
                    }

                    wholeNumbers.Add(wholeNumber);
                }              

                return wholeNumbers.ToImmutableList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
    }
}
