using Newtonsoft.Json;
using System.Collections.Generic;


namespace Entities
{
    public class Post : AuditableEntity
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public int BoardId { get; set; }
        public virtual Board Board { get; set; }
        [JsonIgnore]
        public virtual ICollection<Comment> Comments { get; set; }
        public Post(int boardId, string header, string content)
        {
            BoardId = boardId;
            Header = header;
            Content = content;
        }
        public Post()
        {

        }
    }
}