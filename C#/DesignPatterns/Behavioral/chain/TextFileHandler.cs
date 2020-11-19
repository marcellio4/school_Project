using System;

namespace worksheet_eight_behavioural_design_patterns
{
    public class TextFileHandler: IHandler
    {
        private string _textHandler { get; }

        public TextFileHandler(string textHandler)
        {
            _textHandler = textHandler;
        }

        public IHandler Handler { get; set; }
        public void Process(object file)
        {
            var fieldInfo = file as File;
            if (fieldInfo._type == "text")
            {
                Console.WriteLine("Process and saving text file... by " + _textHandler);
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