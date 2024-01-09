using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTL_Web.Infrastructure
{
    public interface IMessageSystem
    {
        void Send(Message msg);
    }
}