using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' though alice 'without pictures or conversation?'";
 
            Console.WriteLine("What word would you like to find?");
            string searchWord = Console.ReadLine().ToLower();
            bool wordExists;
            if (firstSentence.IndexOf(searchWord) != -1)
            {
                wordExists = true;
                int wordLength = searchWord.Length;
                int wordIndex = firstSentence.IndexOf(searchWord);
                Console.WriteLine(wordLength);
                int firstSentenceLength = firstSentence.Length;
                string substringA = firstSentence.Substring(0, wordIndex);
                int startSubstringB = wordLength + wordIndex;
                int endSubstringB = firstSentenceLength - startSubstringB;
                string substringB = firstSentence.Substring(startSubstringB, endSubstringB);
                string newString = substringA + substringB;
                Console.WriteLine(newString);
            }
            else
            {
                wordExists = false;
            }
            Console.WriteLine(wordExists);
        }
    }
}
