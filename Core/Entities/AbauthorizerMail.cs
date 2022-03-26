using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AbauthorizerMail
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? MailSendDate { get; set; }
        public int? MailSendYear { get; set; }
        public bool? IsMailSend { get; set; }
    }
}
