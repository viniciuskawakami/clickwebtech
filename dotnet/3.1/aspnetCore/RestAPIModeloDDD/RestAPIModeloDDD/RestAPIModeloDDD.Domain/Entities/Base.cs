using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RestAPIModeloDDD.Domain.Entities
{
    internal class Base
    {
        [Key]
        public Guid Id { get; set; }
        public string NickName { get; set; }
        public bool IsActive { get; set; }
        public DateTime created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public DateTime Deleted_At { get; set; }
    }
}
