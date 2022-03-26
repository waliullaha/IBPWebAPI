using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Channel
    {
        public Channel()
        {
            AbproductChannels = new HashSet<AbproductChannel>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int EntryUserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<AbproductChannel> AbproductChannels { get; set; }
    }
}
