using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class SendEmailQueue
    {
        public int Id { get; set; }
        public int Abid { get; set; }
        public int UserId { get; set; }
        public string MailTo { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public DateTime? QueuedDate { get; set; }
        public DateTime? SendDate { get; set; }
        public bool IsSend { get; set; }
    }
}
