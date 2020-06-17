using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Comment : AuditableEntity
    {
        public string Text { get; set; }
        public virtual Post Post { get; set; }
        public Comment(string text)
        {
            Text = text;
        }
        public Comment()
        {

        }
    }
}
