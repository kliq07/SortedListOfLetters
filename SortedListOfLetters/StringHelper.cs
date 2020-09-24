using System;
using System.Collections.Generic;
using System.Text;

namespace SortedListOfLetters
{
    public class StringHelper
    {
        private string _inputStr;

        public StringHelper(string inputStr)
        {
            _inputStr = inputStr;
        }

        public StringHelper RemoveNumbers()
        {
            var tempStrInput = _inputStr;

            ///manipulate tempStrInput
            ///

            _inputStr = tempStrInput;
            return this;
        }

        public StringHelper RemoveSpaces()
        {
            return this;
        }

        public StringHelper RemoveSpecialChars()
        {
            return this;
        }

        public StringHelper ToLowerCaseString()
        {
            return this;
        }

        public StringHelper SortString()
        {
            return this;
        }
        
        public override string ToString()
        {
            return _inputStr;
        }
    }
}
