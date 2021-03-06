﻿/*
 Problem 5. Parse tags

    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
    The tags cannot be nested.

Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */
namespace _05.ParseTags
{
    using System;
    class ParseTags
    {
        static void Main()
        {
            string example = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string result = TagParser.ParseUppercase(example);
            Console.WriteLine(result);
        }
    }
}
