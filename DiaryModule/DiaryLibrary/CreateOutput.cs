using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryLibrary
{
    public class CreateOutput
    {
        private readonly IWriteAble _writeAble;
        public CreateOutput(IWriteAble writeAble)
        {
            this._writeAble = writeAble;
        }

        public void WriteFile(string targetFileNameAndPath, List<string> contents)
        {
            _writeAble.WriteContent(targetFileNameAndPath, contents);
        }
    }
}
