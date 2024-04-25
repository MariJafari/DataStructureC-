using System;
using System.Text;

namespace Question_2
{
    /// <summary>
    /// Provides extension methods for StringBuilder to count the number of words in its content.
    /// </summary>
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Counts the number of words in the content of the StringBuilder.
        /// </summary>
        /// <param name="sb">The StringBuilder instance.</param>
        /// <returns>The number of words in the content of the StringBuilder.</returns>
        public static int WordCount(this StringBuilder sb)
        {
            if (sb == null || sb.Length == 0)
            {
                return 0;
            }

            int wordCount = 0;
            bool inWord = false;
            int length = sb.Length;

            for (int i = 0; i < length; i++)
            {
                char currentChar = sb[i];

                if (char.IsLetterOrDigit(currentChar))
                {
                    // If a letter or digit is encountered, set inWord to true.
                    inWord = true;
                }
                else if (inWord)
                {
                    // If a non-letter or non-digit character is encountered, and we were in a word,
                    // increment the word count and reset the inWord flag.
                    wordCount++;
                    inWord = false;
                }
            }

            // If the last character in the StringBuilder was part of a word,
            // increment the word count one more time.
            if (inWord)
            {
                wordCount++;
            }

            return wordCount;
        }

        static void Main()
        {
            
            StringBuilder textBuilder = new StringBuilder("This it to test whether the extension method count can return a right answer or not.");

            
            int wordCount = textBuilder.WordCount();

            
            Console.WriteLine("Number of words in the text: " + wordCount);

            
        }
    }
}
