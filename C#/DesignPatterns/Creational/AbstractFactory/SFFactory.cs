using System;

namespace QuestionOne
{
    public class SFFactory : IAbstractParserFactory
    {
        public IXMLParser GetParserInstance(string parserType)
        {
            return parserType switch
            {
                "SFCORDER" => (IXMLParser) new NYCOrderXMLParser(),
                "SFFEEDBACK" => new NYCFeedbackXMLParser(),
                "SFERROR" => new NYCErrorXMLParser(),
                "SFRESPONSE" => new NYCResponseXMLParser(),
                _ => throw new Exception("No such message exist!")
            };
        }
    }
}