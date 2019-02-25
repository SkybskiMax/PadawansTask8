using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


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
            HashSet<string> words = new HashSet<string>(text.Split(new char[] { '.', ',', '?', '-', ':', ';', ' '}));
            text.Split(new char[] { ':', ' ' });
            foreach (string word in words)
            { 
                if (word.Length == 0)
                {
                    continue;
                }
                string pattern = word;
                string replace = "";
                string temp = text.Substring(text.IndexOf(pattern) + pattern.Length);
                text = text.Replace(temp, temp.Replace(pattern, replace));
            }

        }
    }
}
