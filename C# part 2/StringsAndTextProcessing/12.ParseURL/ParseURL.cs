/*
 Problem 12. Parse URL

    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

Example:
                    URL 	                                                  Information
http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
                                                        [server] = telerikacademy.com
                                                        [resource] = /Courses/Courses/Details/212
 */
namespace _11.ParseURL
{
    using System;
    class ParseURL
    {
        static void Main()
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            Console.WriteLine(UrlParser(url));
        }

        private static string UrlParser(string input)
        {
            Url url = new Url();
            string[] data = input.Split(new char[] { ':', '/' },StringSplitOptions.RemoveEmptyEntries);
            url.Protocol = data[0];
            url.Server = data[1];
            string resourse = String.Empty;
            for (int i = 2; i < data.Length; i++)
            {
                resourse += "/" + data[i];
            }
            url.Resource = resourse;

            string result = "[protocol] = " + url.Protocol + "\n[server] = " + url.Server + "\n[resourse] = " + url.Resource;
            return result;
        }
    }
}
