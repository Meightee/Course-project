﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Post : AuditableEntity
    {
        public string PostUrl { get; set; }
        public string Header { get; set; }
        public string Сontent { get; set; }
    }
}
