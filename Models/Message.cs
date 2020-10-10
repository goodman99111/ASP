using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatASP.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string User {get;set;}
        public string Msg { get; set; }
    }
}
