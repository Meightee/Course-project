using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Board : AuditableEntity
    {
        public string BoardName { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public Board()
        {

        }

    }
}
