using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR.Models.TaskModel
{
    internal class TaskType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }
}
