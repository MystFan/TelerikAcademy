/*
 Problem 18. Extract e-mails

    Write a program for extracting all email addresses from given text.
    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */
namespace _18.ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    class ExtractEmails
    {
        static void Main()
        {
            string text = "Lorem ipsum dolor sit amet,liberty042@mail.ru consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut karagisekov@mail.ru laoreet dolore magna aliquam erat volutpat.uvarova_ln@mail.ru Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.edwardbuma02@hotmail.com Duis autem vel eum iriure dolor grace1todd1@daum.net in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.";
            string[] emails = Extract(text);
            for (int i = 0; i < emails.Length; i++)
            {
                Console.WriteLine(emails[i]);
            }
        }

        private static string[] Extract(string text)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            List<string> list = new List<string>();
            char[] separators = new char[] { ' ', ',' };

            string[] split = text.Split(separators);
            for (int i = 0; i < split.Length; i++)
            {
                Match m = regex.Match(split[i]);
                if (m.Success)
                {
                    list.Add(split[i].TrimEnd('.'));
                }
            }
            return list.ToArray();
        }
    }
}
