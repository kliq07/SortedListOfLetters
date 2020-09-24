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

        public StringHelper IsNullOrEmptyString()
        {
            bool isEmptyString = String.IsNullOrEmpty(_inputStr);
            
            if(!(isEmptyString))
                return this;
            return null;
        }

        public StringHelper ToLowerCaseString()
        {
            _inputStr= _inputStr.ToLower();
            return this;
        }

        public StringHelper RemoveSpacesAndSpecialChars()
        {
            var tempStrInput = _inputStr;

            var charArr = new char[_inputStr.Length];

            int count = 0;

            foreach (var c in _inputStr)
            {
                if ((c >= '0' && c <= '9')
                    || (c >= 'A' && c <= 'Z')
                    || (c >= 'a' && c <= 'z'))
                {
                    charArr[count] = c;
                    count++;
                }
            }

            _inputStr = new string(charArr, 0, count);

            return this;
        }

        public StringHelper RemoveNumbers()
        {
            var tempStrInput = _inputStr;
            var charArr = new char[_inputStr.Length];
            int count = 0;

            //Could have used Regex but not sure if it is allowed as it states we should not use built in libraries

            foreach(var c in tempStrInput)
            {
                if (!(c >= '0' && c <= '9'))
                {
                    charArr[count] = c;
                    count++;
                }
            }

            _inputStr = new string(charArr, 0, count);
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
