using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class DVDRomUI : IReadFile
    {
        public byte[] ReadFile(string FileName)
        {
            throw new NotImplementedException();
        }
    }

    public class NtfsUI : IReadFile, IWriteFile
    {
        public byte[] ReadFile(string FileName)
        {
            throw new NotImplementedException();
        }

        public void WriteFile(byte[] Content, string FileName)
        {
            throw new NotImplementedException();
        }
    }
}
