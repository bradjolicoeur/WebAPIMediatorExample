using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Core.Pipeline
{
    public interface IHaveAuthorizationData
    {
        string Message { get; set; }
    }
}
