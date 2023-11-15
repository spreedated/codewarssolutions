using System;

namespace Solutions.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class KataAttribute : Attribute
    {
        public string Id { get; init; }
        public bool IsFinished { get; init; }
        public KataAttribute(string id, bool isFinished = true)
        {
            this.Id = id;
            this.IsFinished = isFinished;
        }
    }
}
