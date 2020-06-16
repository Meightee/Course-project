using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class Comment : AuditableEntity
    {
        public string CommenUrl { get; set; }
        public string Text { get; set; }
    }
}
