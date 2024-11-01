namespace BigramHistogramApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parser = new BigramParser();

            // string input for bigram parsing
            string text = "Wandering through the misty morning, Leyna paused to breathe. " +
                          "The mist swirled softly, hiding and revealing shapes. " +
                          "Through the trees, she heard soft whispers; the forest, alive and breathing. " +
                          "Leyna stepped forward, embracing the calm. Misty mornings were her sanctuary, " +
                          "a place to breathe and feel the earth beneath her feet.";
            var bigramCounts = parser.ParseTextToBigrams(text);

            // Display the histogram output
            parser.DisplayBigramHistogram(bigramCounts);
        }
    }
}
