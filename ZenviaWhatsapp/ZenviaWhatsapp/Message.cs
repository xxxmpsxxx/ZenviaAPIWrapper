using System;
using System.Collections.Generic;
using System.Text;

namespace ZenviaWhatsapp
{
    public class Message
    {
        public string from { get; set; }
        public string to { get; set; }
        public Content[] contents { get; set; }        
    }

    public class Content
    {
        public string type { get; set; }
        public string text { get; set; }
    }
}
