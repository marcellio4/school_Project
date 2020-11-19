using System;

namespace QuestionOne
{
    public static class ParserFactoryProducer
    {
        public static IAbstractParserFactory GetFactory(string factory) => factory switch
        {
            "NYCFactory" => new NYCFactory(),
            "SFFactory" => new SFFactory(),
            _ => null
        };
    }
}