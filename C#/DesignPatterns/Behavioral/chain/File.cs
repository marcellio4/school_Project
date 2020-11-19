using System.Dynamic;

namespace worksheet_eight_behavioural_design_patterns
{
    /// <summary>
    /// This is just a dummy class rather than using a real class - a mock.
    /// </summary>
    public class File
    {
        public string _filename { get; }
        public string _type { get; }
        public string _location { get; }
        public File(string fileName, string type, string location)
        {
            _filename = fileName;
            _type = type;
            _location = location;
        }  
    }
}