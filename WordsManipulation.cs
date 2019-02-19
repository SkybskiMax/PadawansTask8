using System;
using System.Text;
using System.Collections.Generic;


namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException();
            }
            if (text.Length == 0)
            {
                throw new ArgumentException();
            }
            StringBuilder str = new StringBuilder(text);
            HashSet<string> words = new HashSet<string>(text.Split());
            foreach (string word in words)
            {
                if (word.Length == 0)
                {
                    break;
                }
                int i = str.ToString().IndexOf(word) + word.Length;
                str.Replace(word, "", i, str.Length - i);
            }
            text = str.ToString();
        }
    }
}