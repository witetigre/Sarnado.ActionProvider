
using Sarnado.ActionProvider.ActionServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sarnado.ActionProvider.ActionHandler.ActionExecutors.Entities
{
    internal class ActionExecutor : IActionExecutor
    {
        private IAction _action;

        public ActionExecutor(IAction action)
        {
            _action = action;
         
        }
        public async Task<object> Decline()
        {
          return await _action.Decline();
        }

        public async Task<object> Execute()
        {
            return await _action.Execute();
        }
    }
}
