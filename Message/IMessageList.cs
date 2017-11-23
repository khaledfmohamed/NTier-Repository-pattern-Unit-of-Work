
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageTube
{
    public interface IMessageList : IEnumerable  , IEnumerable <IMessage>
    {
        MessageEnum Type { get; set; }
        int Count { get;}
        void Add(IMessage message);
        void Remove(IMessage message);
        int ErrorMessagesCount { get; }
        int InfoMessagesCount { get; }
        int WarnnigMessagesCount { get; }
        int SuccessMessagesCount { get; }
        IEnumerable<IMessage> ErrorMessages { get; }
        IEnumerable<IMessage> InfoMessages { get; }
        IEnumerable<IMessage> WarnnigMessages { get; }
        IEnumerable<IMessage> SuccessMessages { get; }
    }
}
