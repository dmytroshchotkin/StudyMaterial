using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace RegExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region RegEx methods. Matches and IsMatch

            //string text = "This is a string #1. And this is a string #2.";
            //string pattern = "string";

            //Console.WriteLine("The text: " + text);
            //Console.WriteLine("The pattern: " + pattern);

            //#region matches

            ////MatchCollection mc = Regex.Matches(text, pattern);

            ////Console.WriteLine("found " + mc.Count + " matches");
            ////foreach (Match m in mc)
            ////{
            ////    Console.WriteLine(m);
            ////}

            //#endregion

            //#region IsMatch

            ////bool isMatchFound = Regex.IsMatch(text, pattern);
            ////Console.WriteLine(isMatchFound ? "found" : "not found");

            //#endregion

            #endregion

            #region StartsWith & EndsWith (word boundary)
            /*
                \b - word boundary
                \S - not white space
                *  - meets zero or more times
            */

            //string text = "This is a string #1. And this is a string #2. That's strange, where is the string #3";
            //string pattern = @"\bs\S*g\b";

            //Console.WriteLine("The text: " + text);
            //Console.WriteLine("The pattern: " + pattern);

            //FindAndDisplayAllMatches(text, pattern);

            #endregion

            #region Range of characters []

            /*
                /w -- alphanumerical characters and underscore 
                [] -- range of characters
            */

            //string text = "This is a string #1. And strung is not a string #2. That's strange, where is the string #3? It's the strangest thing ever.";
            //string pattern = @"\bstr[ia]*ng\w*\b";

            //Console.WriteLine("The text: " + text);
            //Console.WriteLine("The pattern: " + pattern);

            //FindAndDisplayAllMatches(text, pattern);

            #endregion

            #region Grouping

            /*
                ()  --  group a set of characters to apply a quatifier             
                +   --  meets 1 or more times 
                |   --  is used inside the round bracket for using an alternative for example (a | b).
                \d  -- digit
            */

            #region grouping #1

            //string text = "st strstr strstrstr strstrstrstr";
            //string pattern = @"\b(str)+\b";

            //Console.WriteLine("The text: " + text);
            //Console.WriteLine("The pattern: " + pattern);

            //FindAndDisplayAllMatches(text, pattern);

            #endregion

            #region grouping #2

            //string text = "st rt strstr rtrstrrtr strrtrstrrtr rtrrtr";
            //string pattern = @"\b(str|rtr)+\b";

            //Console.WriteLine("The text: " + text);
            //Console.WriteLine("The pattern: " + pattern);

            //FindAndDisplayAllMatches(text, pattern);

            #endregion

            #region nested grouping

            //string text = "abcd bcda cdab dabc abef ab123 cdef cd123 cd345 c12 d32 acd bcd a b c d";
            //string pattern = @"\b(((a|b)cd)|((c|d)\d+))\b"; //if starts with a or b then must continue with c or d. if starts with c or d then must continue with a number

            //Console.WriteLine("The text: " + text);
            //Console.WriteLine("The pattern: " + pattern);

            //FindAndDisplayAllMatches(text, pattern);

            #endregion

            #region complex grouping

            ////!!!! I don't know the pattern
            //string text = "ab de abc def abcabc defdef abcdef defabc abcdefdef defabcabc abcdefabc defabcdef abcdefabc123 defabcdef123 abcdefabcdef defabcdefabc";
            //string pattern = @""; //It can be a 'abc' or 'def' or a sequence 'abcdef' or 'defabc' but not 'abcabc' or any other combination

            //Console.WriteLine("The text: " + text);
            //Console.WriteLine("The pattern: " + pattern);

            //FindAndDisplayAllMatches(text, pattern);

            #endregion

            #region replace a group with another characters

            //string text = "st rt str rtr strstr rtrstrrtr strrtrstrrtr rtrrtr aaaa bbb ccc";
            //string pattern = @"\b(str|rtr)+\b";

            //Console.WriteLine("The text: " + text);
            //Console.WriteLine("The pattern: " + pattern);

            //FindAndDisplayAllMatches(text, pattern);

            //var newStr = Regex.Replace(text, pattern, "[replaced]");
            //Console.WriteLine("\nAfter repalcing:\n" + newStr);

            #endregion

            #region replace a group with capitalized letters (without changing characters)

            //string text = "st rt str rtr strstr rtrstrrtr strrtrstrrtr rtrrtr aaaa bbb ccc";
            //string pattern = @"\b(str|rtr)+\b";

            //Console.WriteLine("The text: " + text);
            //Console.WriteLine("The pattern: " + pattern);

            //FindAndDisplayAllMatches(text, pattern);

            //var newStr = Regex.Replace(text, pattern, match => match.Value.ToUpper());
            //Console.WriteLine("\nAfter repalcing:\n" + newStr);

            #endregion

            #region Find duplicated groups

            //string pattern = @"(\w+)\s(\1)\W";
            //string input = "He said that that was the the correct answer.";

            //Console.WriteLine(input);
            //foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
            //{
            //    Console.WriteLine("Duplicate '{0}' found at positions {1} and {2}.",
            //                      match.Groups[1].Value, match.Groups[1].Index, match.Groups[2].Index);
            //}

            #endregion

            #region Replace 1st group with 2nd group value and vice versa

            ////!!!!!!!!! Not correct yet

            //string text = "st rt str rtr str rtr aaaa bbb ccc";
            //string pattern = @"\b(str|rtr)+\b";

            //Console.WriteLine("The text: " + text);
            //Console.WriteLine("The pattern: " + pattern);

            //FindAndDisplayAllMatches(text, pattern);

            //var matchEvaluatorFunc = new MatchEvaluator((Match match) =>
            //{
            //    if (match.Groups[0].Success)
            //    {
            //        return match.Groups[1].Value;
            //    }
            //    else
            //    {
            //        return match.Groups[0].Value;
            //    }
            //});

            //var newStr = Regex.Replace(text, pattern, matchEvaluatorFunc);
            //Console.WriteLine("\nAfter repalcing:\n" + newStr);

            #endregion

            #endregion
        }


        static void FindAndDisplayAllMatches(string text, string pattern)
        {
            MatchCollection mc = Regex.Matches(text, pattern);

            Console.WriteLine($"\nFound {mc.Count} matches:");
            int i = 1;
            foreach (Match m in mc)
            {
                Console.WriteLine($"{i++.ToString()+ ")", -3}" + m);
            }
        }
    }
}