using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class UserDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
        public bool IsAbright { get; set; }
        public bool IsFinanceLimit { get; set; }
        public bool IsBrandManager { get; set; }
        public bool IsAdministrator { get; set; }
    }
}
