﻿/*
 * You are given a text. Write a program that changes the text in all
 * regions surrounded by the tags <upcase> and </upcase> to uppercase.
 * The tags cannot be nested.
 * Example:
 * We are living in a <upcase>yellow submarine</upcase>.
 * We don't have <upcase>anything</upcase> else.
 * 
 * The expected result:
 * We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

namespace CaseSwitcher
{
    using System;
    using System.Text.RegularExpressions;

    public class CaseSwitcher
    {
        public static string TakeUserInput(string adviseString)
        {
            Console.WriteLine(adviseString);
            string userExpression = Console.ReadLine();
            return userExpression;
        }

        public static void Main(string[] args)
        {
            string userString = TakeUserInput("Enter a string with necessary tags: ");
            string changedString = Regex.Replace(
                                                 userString,
                                                 @"(?<=<upcase>)(.+?)(?=</upcase>)",
                                                 delegate(Match match)
                                                 {
                                                     string text = match.ToString();
                                                     return text.ToUpper();
                                                 });

            changedString = Regex.Replace(changedString, @"<.+?>", string.Empty);
            Console.WriteLine();
            Console.WriteLine(changedString);
        }
    }
}
