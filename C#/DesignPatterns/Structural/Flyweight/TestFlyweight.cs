using System;

namespace Flyweight
{
    public static class TestFlyweight
    {
        public static void Main(string[] args)
        {
            var code = new Code("C Code...");
            var platform = PlatformFactory.PlatformInstance("C");
            const string line = "--------------------";

            platform.Execute(code);
            Console.WriteLine(line);

            code = new Code("C Code2...");
            platform = PlatformFactory.PlatformInstance("C");
            platform.Execute(code);
            Console.WriteLine(line);

            code = new Code("JAVA Code...");
            platform = PlatformFactory.PlatformInstance("JAVA");
            platform.Execute(code);
            Console.WriteLine(line);

            code = new Code("JAVA Code2...");
            platform = PlatformFactory.PlatformInstance("JAVA");
            platform.Execute(code);
            Console.WriteLine(line);

            code = new Code("RUBY Code...");
            platform = PlatformFactory.PlatformInstance("RUBY");
            platform.Execute(code);
            Console.WriteLine(line);

            code = new Code("RUBY Code2...");
            platform = PlatformFactory.PlatformInstance("RUBY");
            Console.WriteLine(line);
        }
    }
}