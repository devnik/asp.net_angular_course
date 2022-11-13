using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    // sending dto
    public class MessageDTO
    {
         public int Id { get; set; }

        // for relationship
        public int SenderId { get; set; }
        public string SenderUsername { get; set; }
        public string SenderPhotoUrl { get; set; } 
        public int RecipientId { get; set; }
        public string RecipientUsername { get; set; }
        public string RecipientPhotoUrl { get; set; }

        // for message specifics
        public string Content { get; set; }
        public DateTime? DateRead { get; set; } // optional, can be null if messaged has been read
        public DateTime MessageSent { get; set; }
    }
}