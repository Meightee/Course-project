using System.Collections.Generic;
using Newtonsoft.Json;

namespace Entities
{
    public class Board : AuditableEntity
    {
        public string BoardName { get; set; }
        [JsonIgnore]
        public virtual ICollection<Post> Posts { get; set; }
        public Board(string name)
        {
            BoardName = name;
        }
        public Board()
        {

        }

    }
}
