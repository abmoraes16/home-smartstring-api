using System;
using System.Collections;
using System.Linq;
using SmartString.Domain.Service;

namespace SmartString.Infrastructure.Services
{
    public class ProccessString : IProccessString
    {
        public string SearchPalindromicString(string value)
        {
            string inverted = stringReverse(value);
            string concatString = "";
            string palindromic = "";

            if(value == inverted)
                return value;

            foreach(char c in inverted)
            {
                concatString = string.Concat(concatString, c);
                if(value.Contains(concatString))
                    if(stringReverse(concatString) == concatString && concatString.Length>1)
                        palindromic = validationLengthIsLonger(concatString, palindromic);
                else
                    concatString = concatString.Substring(concatString.Length-1);
            }
            
            return palindromic;
        }

        public string stringReverse(string stringToRevert){
            return new string(stringToRevert.Reverse().ToArray());
        }

        public string validationLengthIsLonger(string value1, string value2)
        {
            return value1.Length > value2.Length ? value1 : value2;
        }
    }
}