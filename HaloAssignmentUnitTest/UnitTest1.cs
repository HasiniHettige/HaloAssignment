using System.Collections.Generic;
using Xunit;
using HaloAssignmentDemo;
using System.Collections.Immutable;

namespace HaloAssignmentUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void GetWholeNumbers_Input1_Success()
        {
            List<long> wholeNumbers = new();

            //Input : string with whole number, returns whole number
            var result = ManageConversions.GetWholeNumbers("1234");

            wholeNumbers.Add(1234);

            Assert.Equal(wholeNumbers, result);


        }

        [Fact]
        public void GetWholeNumbers_Input2_Success()
        {
            List<long> wholeNumbers = new();

            //Input : string with decimal number, returns rounded whole number
            var result = ManageConversions.GetWholeNumbers("1234.67");

            wholeNumbers.Add(1235);

            Assert.Equal(wholeNumbers, result);
        }

        [Fact]
        public void GetWholeNumbers_Input3_Success()
        {
            List<long> wholeNumbers = new();

            //Input : string with text and whole number, returns just the whole number
            var result = ManageConversions.GetWholeNumbers("This text contains 1234");

            wholeNumbers.Add(1234);

            Assert.Equal(wholeNumbers, result);
        }

        [Fact]
        public void GetWholeNumbers_Input4_Success()
        {
            List<long> wholeNumbers = new();

            //Input : string with text and decimal number, returns just the rounded whole number
            var result = ManageConversions.GetWholeNumbers("This text contains 1234.67");

            wholeNumbers.Add(1235);

            Assert.Equal(wholeNumbers, result);
        }

        [Fact]
        public void GetWholeNumbers_Input5_Success()
        {
            List<long> wholeNumbers = new();

            //Input : string with more than one number, returns list of whole numbers
            var result = ManageConversions.GetWholeNumbers("This text contains 1234 and 1234.67");

            wholeNumbers.Add(1234);
            wholeNumbers.Add(1235);

            Assert.Equal(wholeNumbers, result);
        }

        [Fact]
        public void GetWholeNumbers_Input6_Success()
        {
            List<long> wholeNumbers = new();

            //Input : string with negative whole number, returns negative whole number
            var result = ManageConversions.GetWholeNumbers("-1234");

            wholeNumbers.Add(-1234);

            Assert.Equal(wholeNumbers, result);
        }

        [Fact]
        public void GetWholeNumbers_Input7_Success()
        {
            List<long> wholeNumbers = new();

            //Input : string with negative whole number, returns negative whole number
            var result = ManageConversions.GetWholeNumbers("-1234.67");

            wholeNumbers.Add(-1235);

            Assert.Equal(wholeNumbers, result);
        }

        [Fact]
        public void GetWholeNumbers_Input8_Success()
        {
            List<long> wholeNumbers = new();

            //Input : string with 0, returns 0
            var result = ManageConversions.GetWholeNumbers("0");

            wholeNumbers.Add(0);

            Assert.Equal(wholeNumbers, result);
        }

        [Fact]
        public void GetWholeNumbers_Input9_Success()
        {
            List<long> wholeNumbers = new();

            //Input : string which does not contain any numbers, returns an empty list
            var result = ManageConversions.GetWholeNumbers("This string has no numbers");

            Assert.Equal(wholeNumbers.ToImmutableList(), result);
        }
    }
}