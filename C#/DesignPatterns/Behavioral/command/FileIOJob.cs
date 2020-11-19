using System;
using System.Net.Sockets;

namespace command
{
    public class FileIOJob : IJob
    {
        private FileIO receiver;
        public void Run()
        {
            receiver.Execute();
        }

        public void FileIO(FileIO fileIo)
        {
           receiver = fileIo;
        }
    }
}