using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace DiaryLibrary
{
    public class TextFileWriter : IWriteAble
    {
        public void WriteContent(string targetFileNameAndPath, List<string> contents)
        {
            try
            {
                SetOutput.DoesFileExits(targetFileNameAndPath);

                var textWriter = new StreamWriter(targetFileNameAndPath);
                foreach (var content in contents)
                    textWriter.WriteLine(content);
                textWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return;
        }
    }
}
