using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest
{
    public class Message
    {
        private readonly string message;
        private readonly MessageType type;

        public Message(string message, MessageType logType)
        {
            this.message = message;
            this.type = logType;
        }

        public MessageType Type => type;

        public override string ToString() => $"{DateTime.Now.ToShortDateString()} {type} {message}";
    }
}
