/*
 Problem 4. Download file

    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    Find in Google how to download files in C#.
    Be sure to catch all exceptions and to free any used resources in the finally block.

 */
namespace _04.DownloadFile
{
    using System;
    using System.Net;
    class DownloadFile
    {
        static void Main()
        {
            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", @"..\..\ninja.png");
            }
            catch (UriFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                webClient.Dispose();
            }
        }
    }
}
