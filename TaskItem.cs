using System;

namespace CyberSecurityBot2
{
    public class TaskItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime? ReminderDate { get; set; }
    }
}