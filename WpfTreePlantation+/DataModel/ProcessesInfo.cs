using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTreePlantation_
{
    public class ProcessesInfo
    {
        public int ProcessesInfoID { get; set; }
        [MaxLength(1000)]
        [Required]
        public string ProcessesName { get; set; }
        [MaxLength(256)]
        public string ProcessesTime { get; set; }
        public string ProcessesType { get; set; }
        public ProcessesInfo(int ProcessesInfoID, string ProcessesName, double ProccessesTime,string ProcessesType)
        {
            this.ProcessesInfoID = ProcessesInfoID;
            this.ProcessesName = ProcessesName;
            this.ProcessesTime = ProcessesTime;
            this.ProcessesType = ProcessesType;
        }
    }
}
