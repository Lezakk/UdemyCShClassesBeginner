using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace UdemyClassesBeginner
{
    class Files
    {
        public static void ReadsTextFileAndReturnNumberOFWords(string path)
        {
            File.SetAttributes(path, FileAttributes.Normal);
            Console.WriteLine(Files.NumberOfWords(Files.ReadTextFile(path)));
        }

        public static string ReadTextFile(string path)
        {
            File.SetAttributes(path, FileAttributes.Normal);
            return File.ReadAllText(path);   
        }
        public static int NumberOfWords(string text)
        {
            List<string> allWords = new List<string>(text.Split(" "));
            return allWords.Count;
        }

        public static string ReturnsLongestWordInFile(string text)
        {
            List<string> allWords = new List<string>(text.Split(" "));
            int maxLetters = 0;
            int indexOfMaxLetter = 0;
            foreach (var word in allWords)
            {
                if (maxLetters < word.Length)
                {
                    maxLetters = word.Length;
                    indexOfMaxLetter = allWords.IndexOf(word);
                }
            }
            return allWords[indexOfMaxLetter];
        }

        public static void LongestWordInFile(string path)
        {
            Console.WriteLine(Files.ReturnsLongestWordInFile(Files.ReadTextFile(path)));
        }

    }
}
