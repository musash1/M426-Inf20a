using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 1, 10 };
            double expected = 5.5;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 1, 10, 13, 6, 24 };
            double expected = 10.8;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfNoNumbers()
        {
            List<int> numbers = new List<int> { };
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Mean(numbers));
        }

        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            List<int> numbers = new List<int> { 1, 10, 13, 6, 24 };
            double expected = 10;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForEvenNumberOfElements()
        {
            List<int> numbers = new List<int> { 1, 10, 13, 6, 24, 5 };
            double expected = 8;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForNoElements()
        {
            List<int> numbers = new List<int> { };
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Median(numbers));
        }
    }
}
