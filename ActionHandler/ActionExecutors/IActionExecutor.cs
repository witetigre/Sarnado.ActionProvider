using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sarnado.ActionProvider.ActionHandler.ActionExecutors
{
    internal interface IActionExecutor
    {
        public Task<object> Execute();
        public Task<object> Decline();
    }
}
