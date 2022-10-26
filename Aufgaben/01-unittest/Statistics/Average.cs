using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            int sum = 0;
            double mean = 0.0;

            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("List must contain at least one Number.");
            }

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }

        public double Median(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("List must contain at least one Number.");
            }

            int size = numbers.Count;
            int mid = size / 2;

            numbers.Sort();

            if (size % 2 != 0)
            {
                return numbers[mid];
            }

            dynamic value1 = numbers[mid];
            dynamic value2 = numbers[mid - 1];
            return (value1 + value2) / 2;
        }
    }
}
