using System;

namespace QuestionOne
{
    public class NYCFactory : IAbstractParserFactory
    {
        public IXMLParser GetParserInstance(string parserType)
        {
            return parserType switch
            {
                "NYCORDER" => (IXMLParser) new NYCOrderXMLParser(),
                "NYCFEEDBACK" => new NYCFeedbackXMLParser(),
                "NYCERROR" => new NYCErrorXMLParser(),
                "NYCRESPONSE" => new NYCResponseXMLParser(),
                _ => throw new Exception("No such message exist!")
            };
        }
    }
}