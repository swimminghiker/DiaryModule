using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryLibrary
{
    public class DispatchOutput
    {
        private readonly IWriteAble _writeAble;
        public DispatchOutput(IWriteAble writeAble)
        {
            this._writeAble = writeAble;
        }
        public void Dispatch(string targetFileNameAndPath, List<string> contents)
        {
            _writeAble.WriteContent(targetFileNameAndPath, contents);
        }
    }
}


