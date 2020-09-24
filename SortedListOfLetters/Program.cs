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
}

