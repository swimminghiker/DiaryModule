using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryLibrary
{
    public class ConsoleWriter : IWriteAble
    {
        public void WriteContent(string targetFileNameAndPath, List<string> contents)
        {
            try
            {
                foreach (var content in contents)
                    Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            return;
        }
    }
}
