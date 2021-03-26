using System.Threading.Tasks;

namespace Sarnado.ActionProvider.ActionServices
{
    interface IActionCollector
    {
        void AddAction(string actionName, IAction action);
        Task ExecuteActionByName(string actionName);
        IAction GetAction(string actionName);
        Task RemoveAction(string name);
    }
}