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

            //Could have used Regex but not sure if it is allowed as it states we should not use built in libraries

            var stringBuilder = new StringBuilder();

            foreach(var c in tempStrInput)
            {
                if (!(Char.IsNumber(c)))
                    stringBuilder.Append(c);                    
            }

            tempStrInput = stringBuilder.ToString();
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
