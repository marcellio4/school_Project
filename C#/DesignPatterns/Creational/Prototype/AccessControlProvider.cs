using System;

namespace QuestionFour
{
    public static class AccessControlProvider
    {
        public static AccessControl GetAccessControlObject(string controlLevel) {
            // is a "string" the best way to implement this?
            return new AccessControl().Clone();
        }
    }
}