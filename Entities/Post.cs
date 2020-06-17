using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Post : AuditableEntity
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public virtual Board Board { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public Post(string header, string content)
        {
            Header = header;
            Content = content;
        }
        public Post()
        {

        }
    }
}