using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstLend.Domain.Entities
{
    public class Notification
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public bool IsSent { get; set; }
        public bool IsRead { get; set; }
        public string Text { get; set; } = "";
        public string CreatedAt { get; set; } = "";

        public User? User { get; set; }
    }
}