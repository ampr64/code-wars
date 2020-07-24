using System.Collections.Generic;

namespace FindTheOddInt
{
    public class FindTheOddInt
    {
        public int Do(int[] sequence)
        {
            var distinctNumbers = GetDistinctNumbers(sequence);
            int result = default;

            foreach (var number in distinctNumbers)
            {
                if (AppearsOddNumberOfTimes(number, sequence))
                {
                    result = number;
                }
            }
            return result;
        }

        private bool AppearsOddNumberOfTimes(int target, int[] sequence) =>
            CountOccurrences(target, sequence) % 2 == 1;

        private IList<int> GetDistinctNumbers(int[] sequence)
        {
            var distinctNumbers = new List<int>();

            for (int i = 0; i < sequence.Length; i++)
            {
                if (!distinctNumbers.Contains(sequence[i]))
                {
                    distinctNumbers.Add(sequence[i]);
                }
            }
            return distinctNumbers;
        }

        private int CountOccurrences(int target, int[] sequence)
        {
            var count = 0;
            foreach (var number in sequence)
            {
                if (number == target)
                {
                    count++;
                }
            }
            return count;
        }
    }
}