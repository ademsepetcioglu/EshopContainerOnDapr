using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshopContainerOnDapr.Abstractions.Model
{
    public class Result<T>
    {
        public Result()
        {
            Messages = new List<string>();
        }
        public virtual ResultType ResultType { get; set; }
        public virtual bool Success { get; set; }
        public virtual List<string> Messages { get; set; }

        [Required(AllowEmptyStrings = true)]
        public virtual T Data { get; set; }
    }
}
