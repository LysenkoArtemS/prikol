using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGR.Models.UserModel;
using RGR.Models.StatusModel;
using RGR.Models.TaskModel;



namespace RGR.Models.TaskModel
{
    internal class TaskInfo
    {
        public Guid TaskId { get; set; }
        public Guid? ParentId { get; set; }

        public UserInfo User { get; set; }
        public UserInfo Manager { get; set; }

        public TaskType Type { get; set; }     
        public string TaskName { get; set; }
        public string Description { get; set; }
        public int PercentageOfDone { get; set; }

        public StatusInfo Status { get; set; }
        public DateTime Deadline { get; set; }

        public List<TaskInfo> Subtasks { get; set; }
    }
}
