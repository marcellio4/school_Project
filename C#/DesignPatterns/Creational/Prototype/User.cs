using System.Text;

namespace QuestionFour
{
    public class User
    {
        public string UserName { get; set; }
        private string Level { get; set; }
        public Access AccessControl { get; set; }

        public User(string name, string level, AccessControl userAccessControl)
        {
            UserName = name;
            Level = level;
            AccessControl = userAccessControl.Access;
        }

        public override string ToString() => new StringBuilder()
            .Append($"Name: {UserName}, Level:{Level}, Access Control Level:{Level}, Access: {AccessControl}")
            .ToString();
    }
}