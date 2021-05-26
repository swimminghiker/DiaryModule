using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiaryLibrary;

namespace DiaryModule
{
    class Program
    {
        //public delegate void MyDel(string path, List<string> contents);
        
        static void Main(string[] args)
        {
            try
            {
                //Get user input and the create contents based on input
                DateTime specifiedDate = GetInput.Get2DigitMonth();
                List<string> contents = new List<string>();
                ContentMaker.CreateLegend(contents);
                ContentMaker.CreateDateHeader(contents, specifiedDate);

                //Sending contents to selected output devices
                var filePath = new SetOutput(specifiedDate);
                string targetFileNameAndPath = filePath["DeskTop"];

                var textFileOutput = new DispatchOutput(new TextFileWriter());
                var consoleOutput = new DispatchOutput(new ConsoleWriter());

                Action<string, List<string>> sendToWrite = textFileOutput.Dispatch;
                sendToWrite += consoleOutput.Dispatch;
                sendToWrite(targetFileNameAndPath, contents);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


