
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MessageTube
{
    public class MessageList : IMessageList 
    {

        List<IMessage> Messages { get; set; }
        public MessageEnum Type { get ; set; }
        public int Count { get => Messages.Count; }

        public IEnumerable<IMessage> ErrorMessages =>  this.Where(p => p.Type == MessageEnum.Error);
        public IEnumerable<IMessage> InfoMessages => this.Where(p => p.Type == MessageEnum.Info);
        public IEnumerable<IMessage> WarnnigMessages => this.Where(p => p.Type == MessageEnum.Info);
        public IEnumerable<IMessage> SuccessMessages => this.Where(p => p.Type == MessageEnum.Success);

        public int ErrorMessagesCount => ErrorMessages.Count();

        public int InfoMessagesCount => InfoMessages.Count();

        public int WarnnigMessagesCount => WarnnigMessages.Count();

        public int SuccessMessagesCount => SuccessMessages.Count();

        public MessageList()
        {
            Messages = new List<IMessage>();

            
        }
        public void Add(IMessage message)
        {
            Messages.Add(message);
           
           
            
        }

        public void Remove(IMessage message)
        {
            Messages.Remove(message);
        }

        public IEnumerator GetEnumerator()
        {
            return Messages.GetEnumerator();
        }

        IEnumerator<IMessage> IEnumerable<IMessage>.GetEnumerator()
        {
            return Messages.GetEnumerator();
        }

        public IMessage this[int index]    
        {
            get
            {
                return Messages[index];
            }
            set
            {
                Messages[index] = value;
            }

        }
       
}
    
}
