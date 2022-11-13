using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Message
    {
        public int Id { get; set; }

        // for relationship
        public int SenderId { get; set; }
        public string SenderUsername { get; set; }
        public AppUser Sender { get; set; } 
        public int RecipientId { get; set; }
        public string RecipientUsername { get; set; }
        public AppUser Recipient { get; set; }

        // for message specifics
        public string Content { get; set; }
        public DateTime? DateRead { get; set; } // optional, can be null if messaged has been read
        public DateTime MessageSent { get; set; } = DateTime.Now;
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; }


    }
}