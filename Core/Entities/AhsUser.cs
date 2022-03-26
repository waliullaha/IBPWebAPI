﻿using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class AhsUser
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public int Gender { get; set; }
    }
}
