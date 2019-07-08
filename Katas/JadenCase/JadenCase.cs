using System.Linq;
using System;
using System.Collections.Generic;

namespace MyNamespace
{
    public static class MyClass
    {
        public static string ToJadenCase(this string phrase)
        {
            if (phrase == string.Empty)
                return string.Empty;

            return string.Join(' ', phrase.Split(' ').Select(w => w.ToCapitalCase()));
        }
        public static string ToCapitalCase(this string word)
        {
            if (word == string.Empty)
                return string.Empty;

            return string.Join("", word.First().ToString().ToUpper(), string.Join("", word.TakeLast(word.Length - 1)));
        }
    }
}