/*
 * C# Program to Randomly Generate Strings
 */

using System;
using System.IO;

namespace randomly_generate_strings
{
    static class Random
    {
        public static string GetRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", "");
            return path;
        }
    }
}
