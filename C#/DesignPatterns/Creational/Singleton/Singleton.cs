namespace QuestionFive
{
    public class Singleton
    {
        // expensive
        private static Singleton single = new Singleton();
        
        
        private Singleton()
        {
            // this is expensive
        }

        public static Singleton GetInstance()
        {
            return single;
        }
    }
}