using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlarmService.Model
{
    public class Alarm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 AlarmId
        {
            get;
            set;
        }

        public DateTime AlarmDateTime
        {
            get;
            set;
        }

        public Int64 DrugID
        {
            get;
            set;
        }

        public bool Confirmed
        {
            get;
            set;
        }

        public string CustomMessage
        {
            get;set;
        }

        public ICollection<UserAlarm> UserAlarms { get; set; }
    }
}
