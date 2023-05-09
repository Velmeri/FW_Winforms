using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW_Winforms.Classes
{
	public enum PRIORITY { LOW, MEDIUM, HIGH }

	public class Goal
	{
		public string Name { get; set; }
		public DateTime ExecutionTime { get; set; }
		public PRIORITY Priority { get; set; }
		public string[] Tags { get; set; }
		public string Description { get; set; }
		public string AttachedFile { get; set; }

		public Goal (string name, DateTime executionTime, PRIORITY priority, string[] tags, string description, string attachedFile)
		{
			Name = name;
			ExecutionTime = executionTime;
			Priority = priority;
			Tags = tags;
			Description = description;
			AttachedFile = attachedFile;
		}
	}
}
