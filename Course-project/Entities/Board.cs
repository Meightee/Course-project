using System;
using System.Collections.Generic;
using System.Text;

namespace Course_project.Entities
{
    class Board : AuditableEntity
    {
        public string BoardUrl { get; set; }
        public string BoardName { get; set; }
        
    }
}
