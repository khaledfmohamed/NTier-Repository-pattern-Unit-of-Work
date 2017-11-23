
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageTube
{
    public class Message : IMessage
    {
        public string Body { get; set; }
        public string Title { get; set; }
        public MessageEnum Type { get; set; }
       
    }
}
