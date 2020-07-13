using System;
using System.Collections.Generic;
using System.Text;


namespace Entities
{
    public class Comment : AuditableEntity
    {
        public string Text { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public Comment(int postId, string text)
        {
            PostId = postId;
            Text = text;
        }
        public Comment()
        {

        }
    }
}
