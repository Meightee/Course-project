using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Post : AuditableEntity
    {
        public string Header { get; set; }
        public string Сontent { get; set; }
        public virtual Board Board { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public Post()
        {

        }
    }
}