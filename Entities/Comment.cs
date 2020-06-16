using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Comment : AuditableEntity
    {
        public string Text { get; set; }
        public Post Post { get; set; }
    }
}
