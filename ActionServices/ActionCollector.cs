using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sarnado.ActionProvider.ActionServices
{
    class ActionCollector : IActionCollector
    {
        private Dictionary<string, IAction> Actions { get; }

        public void AddAction(string actionName, IAction action)
        {
            Actions.Add(actionName, action);
        }

        public IAction GetAction(string actionName)
        {
            return Actions[actionName];
        }
        public async Task ExecuteActionByName(string actionName)
        {
            await Actions[actionName].Execute();
        }

        public async Task RemoveAction(string name)
        {
            Actions.Remove(name);
        }
    }
}
