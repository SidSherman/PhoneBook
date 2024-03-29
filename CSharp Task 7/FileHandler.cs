﻿using System;
using System.Collections;
using System.Xml.Linq;

namespace PhoneBook
{
    class FileHandler
    {
        static public ArrayList ReadFile(string path)
        {
            if (!File.Exists(path))
                return new ArrayList();

            ArrayList lines = new ArrayList();

            using (StreamReader stream = new StreamReader(path))
            {
                while (!stream.EndOfStream)
                {
                    lines.Add(stream.ReadLine());
                }
            }
            return lines;
        }

        static public void WriteLineInFile(string path, string data, bool shouldAppend)
        {
            using (StreamWriter stream = new StreamWriter(path, shouldAppend))
            {
                    stream.WriteLine(data);
            }
        }

        static public void WriteLineInFile(string path, XElement data, bool shouldAppend)
        {
            using (StreamWriter stream = new StreamWriter(path, shouldAppend))
            {
                stream.WriteLine(data);
            }
        }


        static public void FileDelete(string path)
        {
            File.Delete(path);
        }
    }
}
