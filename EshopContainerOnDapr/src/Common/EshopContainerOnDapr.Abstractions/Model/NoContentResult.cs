﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshopContainerOnDapr.Abstractions.Model
{
    public class NoContentResult<T> : Result<T>
    {

        public NoContentResult(string error = null) : base()
        {
            Messages.Add(error ?? "No content found");
        }
        public override ResultType ResultType => ResultType.NoContent;
        public override bool Success => false;
        public override List<string> Messages { get; set; }
        public override T Data => default(T);
    }
}
