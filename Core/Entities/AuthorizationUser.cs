using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AuthorizationUser
    {
        public int Id { get; set; }
        public string AuthoUserId { get; set; }
        public string UserId { get; set; }
        public int AuthorizationTypeId { get; set; }
        public decimal AuthorizationLimits { get; set; }
    }
}
