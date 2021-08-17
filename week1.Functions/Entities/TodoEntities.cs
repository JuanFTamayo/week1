using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace week1.Functions.Entities
{
   public class TodoEntities:TableEntity
    {
        public DateTime CreatedTime { get; set; }
        public string TaskDrescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}
