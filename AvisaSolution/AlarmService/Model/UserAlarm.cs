using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlarmService.Model
{
    public class UserAlarm
    {

        public Int64 UserAlarmId
        {
            get;set;
        }

        public Int64 UserId
        {
            get;
            set;
        }

        public Int64 AlarmId
        { 
            get; 
            set; 
        }
        public User User { get; set; }

        public Alarm Alarm { get; set; }
    }
}
