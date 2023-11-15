using System;

namespace Solutions.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class KataAttribute : Attribute
    {
        public string Id { get; init; }
        public bool IsFinished { get; init; }
        public string Author { get; init; }
        public KataAttribute(string id, string author = null, bool isFinished = true) : base()
        {
            this.Id = id;
            this.IsFinished = isFinished;
            this.Author = author;
        }
    }
}
