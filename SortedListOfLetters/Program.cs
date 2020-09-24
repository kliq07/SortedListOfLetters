using System;
using System.Collections.Generic;

namespace SortedListOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }





        StringHelper _strHelper;

        public Program()
        {
            Console.WriteLine("Enter your string: ");
            var stringInputed = Console.ReadLine();

            _strHelper = new StringHelper(stringInputed).RemoveNumbers()
                .RemoveSpaces()
                .RemoveSpecialChars()
                .SortString()
                .ToLowerCaseString();

            var resultString = _strHelper.ToString();

            Console.WriteLine(resultString);
        }

    }
     class Test
    {
        public Test()
        {
            var listWords = new List<string>(new string[] { "this", "is", "a", "sample", "list", "of", "words", "that", "demonstrates", "some", "code" });

            List<string> filteredWords = new FilterLogic(listWords)
                .FilterOutShortWords()
                .FilterOnlyWordsContainingLetterC()
                .FilterArbitraryComplexItems()
                .FilterSomeMoreArbitraryComplexItems()
                .GetWords();

            Console.WriteLine(String.Join(", ", filteredWords.ToArray()));

        }
    }

    public class FilterLogic
    {
        private List<string> _listWords = new List<string>();

        //Constructor
        public FilterLogic(List<string> listWords)
        {
            _listWords = listWords;
        }

        //Chain Terminator
        public List<string> GetWords()
        {
            return _listWords;
        }

        public FilterLogic FilterOutShortWords()
        {
            _listWords = _listWords.Where(w => w.Length >= 3).ToList();
            return this;
        }

        public FilterLogic FilterOnlyWordsContainingLetterC()
        {
            _listWords = _listWords.Where(word => word.ToLower().Contains("c")).ToList();
            return this;
        }

        public FilterLogic FilterArbitraryComplexItems()
        {
            /* ... some arbitrarily complicated code ... */
            return this;
        }

        public FilterLogic FilterSomeMoreArbitraryComplexItems()
        {
            /* ... some arbitrarily complicated code ... */
            return this;
        }

    }

