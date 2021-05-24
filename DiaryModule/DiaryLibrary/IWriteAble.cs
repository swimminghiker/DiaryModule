using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryLibrary
{
    public interface IWriteAble
    {
        void WriteContent(string fileNameAndPath, List<string> contents);
    }
}
