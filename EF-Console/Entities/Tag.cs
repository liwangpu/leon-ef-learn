using System.Collections.Generic;

namespace EF_Console.Entities
{
    public class Tag
    {
        public string Id { get; protected set; }
        public string Name { get; protected set; }
        public List<AccountTag> OwnAccountTags { get; protected set; }

        public Tag(string name)
        {
            Name = name;
        }
    }
}
