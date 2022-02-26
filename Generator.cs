using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace HuffmanTest
{
    public class Generator
    {
        static private int step = 0;
        const int n = 100;
        static StreamReader sr;
        static string str;
        static public string ParsingText()
        {
            if (str.Length - n * step >= n)
            {
                string ans = null;
                for (int i = n * step; i < n * (step + 1); i++)
                {
                    ans += str[i];
                }
                step += 1;
                return ans;
            }
            else {
                return null;
            }
        }
        public Generator(string path)
        {
            try
            {
                using (sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        str = sr.ReadToEnd();
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}