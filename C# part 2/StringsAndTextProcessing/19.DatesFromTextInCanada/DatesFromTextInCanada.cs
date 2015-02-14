/*
 Problem 19. Dates from text in Canada

    Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
    Display them in the standard date format for Canada.

 */
namespace _19.DatesFromTextInCanada
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Threading;
    class DatesFromTextInCanada
    {
        static void Main()
        {
            string text = "Lorem ipsum dolor sit amet, 01.11.2012 consectetuer adipiscing elit, 01.02.2012 sed diam nonummy nibh euismod tincidunt ut  laoreet dolore magna aliquam erat volutpat Ut wisi enim ad minim veniam, quis nostrud 12.07.2013 exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.edwardbuma02@hotmail.com Duis autem vel eum iriure dolor grace1todd1@daum.net in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.";
            string[] dates = ExtractDates(text);
            for (int i = 0; i < dates.Length; i++)
            {
                Console.WriteLine(dates[i]);
            }
        }

        private static string[] ExtractDates(string text)
        {
            Regex regex = new Regex(@"^(0[1-9]|[12][0-9]|3[01])[.](0[1-9]|1[012])[.](19|20)\d\d$");
            List<string> dates = new List<string>();
            char[] separators = new char[] { ' ', ',' };

            string[] split = text.Split(separators);
            for (int i = 0; i < split.Length; i++)
            {
                Match m = regex.Match(split[i]);
                if (m.Success)
                {
                    dates.Add(split[i].TrimEnd('.'));
                }
            }
            CultureInfo culture = new CultureInfo("en-CA");
            for (int i = 0; i < dates.Count; i++)
            {
                DateTime dt = DateTime.ParseExact(dates[i], "dd.MM.yyyy", culture);
                dates[i] = dt.ToString();
            }
            return dates.ToArray();
        }
    }
}
