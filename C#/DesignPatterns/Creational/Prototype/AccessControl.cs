using System;

namespace QuestionFour
{
    public class AccessControl : IPrototype
    {
        public Access Access { get; set; }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public AccessControl Clone()
        {
            return this.MemberwiseClone() as AccessControl;
        }
    }
}