
using Sarnado.ActionProvider.ActionHandler.ActionExecutors;
using Sarnado.ActionProvider.ActionHandler.ActionExecutors.Entities;
using Sarnado.ActionProvider.ActionServices;
using Sarnado.ActionProvider.ActionServices.Entities;

using System.Threading.Tasks;

namespace Sarnado.ActionProvider.ActionHandler.Entities
{
    public class ActionHandler : IActionHandler
    {
        private IActionExecutor _actionExecutor;
        private IAction _action;
       
        public ActionHandler(IAction action)
        {
            _action         = action;
            _actionExecutor = new ActionExecutor(action);
            
        }
        public async Task<object> TryExecuteAction()
        {
            await _action.TryApproveAction();

            if (_action.Status.Equals(Status.FullAccepted))
            {
                return await _actionExecutor.Execute();
            }
            else {
                return await _actionExecutor.Decline();
            }
        }
    }
}
