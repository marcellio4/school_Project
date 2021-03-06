using System;
using System.Reflection;

namespace worksheet_eight_behavioural_design_patterns
{
    public class AudioFileHandler : IHandler
    {
        private string _textHandler { get; }

        public AudioFileHandler(string textHandler)
        {
            _textHandler = textHandler;
        }

        public IHandler Handler { get; set; }

        public void Process(object file)
        {
            var fieldInfo = file as File;
            if (fieldInfo._type == "audio")
            {
                Console.WriteLine("Process and saving audio file... by " + _textHandler);
            }else if(Handler != null)
            {
                Console.WriteLine(_textHandler + " forward file to " + Handler.GetType().Name);
                Handler.Process(file);
            }
            else
            {
                Console.WriteLine("File not supported");
            }
        }
    }
}