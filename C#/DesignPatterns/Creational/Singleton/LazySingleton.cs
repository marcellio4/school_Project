namespace QuestionFive
{
    public class LazySingleton
    {
        private static LazySingleton _single;
        private LazySingleton()
        {
            
        }
        public static LazySingleton GetInstance()
        {
            if (_single == null)
            {
                _single = new LazySingleton();
            }

            return _single;
        }   
    }
}