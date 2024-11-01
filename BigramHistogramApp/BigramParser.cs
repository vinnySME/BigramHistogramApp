using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BigramHistogramApp
{
    public class BigramParser
    {
        /// <summary>
        /// Method Tp ParseTextToBigrams
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public Dictionary<string, int> ParseTextToBigrams(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Text cannot be null or empty");

            // Convert text to lowercase and remove punctuation
            string normalizedText = Regex.Replace(text.ToLower(), @"[^\w\s]|(?<=\w)(?=\s*\W)", "");
            string[] words = normalizedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bigramCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            // Generate bigrams without wrapping around
            for (int i = 0; i < words.Length - 1; i++)
            {
                string bigram = $"{words[i]} {words[i + 1]}";

                if (bigramCounts.ContainsKey(bigram))
                    bigramCounts[bigram]++;
                else
                    bigramCounts[bigram] = 1;
            }

            return bigramCounts;
        }








        /// <summary>
        /// Method to display bigrams in a histogram format
        /// </summary>
        /// <param name="bigramCounts"></param>
        public void DisplayBigramHistogram(Dictionary<string, int> bigramCounts)
        {
            Console.WriteLine("Bigram Histogram:");
            foreach (var bigram in bigramCounts.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{bigram.Key}: {bigram.Value}");
            }
        }
    }
}
