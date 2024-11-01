# BigramHistogramApp
BigramHistogramApp is a console application designed to parse a given text and display a histogram of bigrams (pairs of consecutive words) found within the text. This can be used for simple text analysis to understand the frequency of word pairs within a text passage.
Features
Parses text and counts bigrams (word pairs).
Ignores punctuation for cleaner analysis.
Outputs a histogram of bigram frequencies.

Project Structure
BigramHistogramApp: Main application that initializes the bigram parser and displays the histogram.
BigramParser: Contains methods to process text input into bigrams and calculate their frequencies.
BigramHistogramApp.Tests: Unit tests for validating the bigram parsing and histogram display functionalities.

Getting Started

Prerequisites
.NET SDK installed on your machine.

Running the Application

Clone the repository:
git clone <repository-url>

Navigate to the project directory

cd BigramHistogramApp

Run the application
dotnet run --project BigramHistogramApp

Example Input
The following text is used as an example within the program: (fyi-Leyna is my daughter name)
Wandering through the misty morning, Leyna paused to breathe. The mist swirled softly, hiding and revealing shapes. Through the trees, she heard soft whispers; the forest, alive and breathing. Leyna stepped forward, embracing the calm. Misty mornings were her sanctuary, a place to breathe and feel the earth beneath her feet.

Expected Output
The application will display a histogram showing the frequency of each bigram found in the input text.

Using Visual Studio Test Explore Run the Tests 

This will execute all test cases in BigramHistogramApp.Tests, which include cases for:

Case-insensitive parsing.
Ignoring punctuation.
Handling empty strings.
Returning correct bigram counts for valid input.

Contributing
If you would like to contribute to this project, please fork the repository and make a pull request with your changes.

License
This project is licensed under the MIT License.







