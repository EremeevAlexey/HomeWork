using System;

namespace ClassLibrary
{
    public class RegexMatchAttribute : Attribute
    {
        public string Pattern;

        public RegexMatchAttribute(string pattern)
        {
            Pattern = pattern;
        }
    }
}