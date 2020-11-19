using System;

namespace worksheet_eight_behavioural_design_patterns
{
    public class DocFileHandler : IHandler
    {
        private string _textHandler;

        public DocFileHandler(string textHandler)
        {
            _textHandler = textHandler;
        }

        public IHandler Handler { get; set; }

        public void Process(object file)
        {
            var fieldInfo = file as File;
            if (fieldInfo._type == "doc")
            {
                Console.WriteLine("Process and saving doc file... by " + _textHandler);
            }
            else if(Handler != null)
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