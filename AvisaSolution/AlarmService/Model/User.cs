using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlarmService.Model
{
    public class User
    {
        [Key]
        public Int64 UserId
        {
            get;
            set;
        }

        public ICollection<UserAlarm> UserAlarms { get; set; }
    }
}
