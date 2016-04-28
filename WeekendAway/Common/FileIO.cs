﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class FileIO
    {
        public static IEnumerable<string> ReadFrom(string file)
        {
            using (var sr = new StreamReader(new FileStream(file, FileMode.Open, FileAccess.ReadWrite)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        public static string ReadAll(string file)
        {
            using (var sr = new StreamReader(new FileStream(file, FileMode.Open, FileAccess.ReadWrite)))
            {
                return sr.ReadToEnd();
            }
        }

        public static void Write(string file, string content)
        {
            using (var sw = new StreamWriter(new FileStream(file, FileMode.Create, FileAccess.ReadWrite)))
            {
                sw.Write(content);
                sw.Flush();
            }
        }
    }
}
