namespace BigramHistogramApp
{
    /// <summary>
    /// This accept any input string and display histogram output
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var parser = new BigramParser();

            Console.Write("Enter input string: ");
            string text = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("No input string entered. Exiting program.");
                return; // Exit the program if no input is provided
            }

            /* hardcoded For Testing only 
               string input for bigram parsing
               string text = "Wandering through the misty morning, Leyna paused to breathe. " +
                         "The mist swirled softly, hiding and revealing shapes. " +
                         "Through the trees, she heard soft whispers; the forest, alive and breathing. " +
                         "Leyna stepped forward, embracing the calm. Misty mornings were her sanctuary, " +
                         "a place to breathe and feel the earth beneath her feet.";
           */

            var bigramCounts = parser.ParseTextToBigrams(text);

            // Display the histogram output
            parser.DisplayBigramHistogram(bigramCounts);
        }
    }
}
