using System;

namespace QuestionFive
{
    public static class TestSingletons
    {
        public static void Main(string[] args)
        {
            var s1 = Singleton.GetInstance();
            Console.WriteLine(s1.GetHashCode());
            var s2 = Singleton.GetInstance();
            Console.WriteLine(s2.GetHashCode());

            var l1 = LazySingleton.GetInstance();
            Console.WriteLine(l1.GetHashCode());
            var l2 = LazySingleton.GetInstance();
            Console.WriteLine(l2.GetHashCode());
        }
    }
}