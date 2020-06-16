using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Board : AuditableEntity
    {
        public string BoardUrl { get; set; }
        public string BoardName { get; set; }

    }
}
